using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Borium.Application.Interfaces;
using Borium.Application.Utils;
using Borium.Webhost.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Borium.Webhost.Extensions {
    /// <summary>
    /// Extensions for <see cref="IServiceCollection">IServiceCollection</see> interface.
    /// </summary>
    public static class ServiceCollectionExtensions {
        /// <summary>
        /// It registers singleton services for CommandConnectionStringWrapper and QueryConnectionStringWrapper.
        /// Connection stirngs are taken from config file.
        /// </summary>
        /// <param name="services">IServiceCollection instance</param>
        /// <param name="Configuration">configuration resolved from project config file</param>
        public static void RegisterConnectionStringWrappers (this IServiceCollection services, IConfiguration Configuration) {
            var commandConnectionString = Configuration["CommandConnectionString"];
            var queryConnectionString = Configuration["QueryConnectionString"];
            var commandConnectionStringWrapper = new CommandConnectionStringWrapper (commandConnectionString);
            var queryConnectionStringWrapper = new QueryConnectionStringWrapper (queryConnectionString);
            services.AddSingleton (commandConnectionStringWrapper);
            services.AddSingleton (queryConnectionStringWrapper);
        }

        /// <summary>
        /// Register Swagger documentation.
        /// </summary>
        /// <param name="services">IServiceCollection instance</param>
        public static void RegisterSwagger (this IServiceCollection services) {
            services.AddSwaggerGen (c => {
                c.SwaggerDoc ("v1", new Info {
                    Version = "v1",
                        Title = "Borium API",
                        Description = "Music Notes application",
                        TermsOfService = "None",
                        Contact = new Contact () { Name = "Piotr Trojan", Email = "kontakt@piotrtrojan.com", Url = "http://www.piotrtrojan.com" }
                });
                c.IncludeXmlComments (GetXmlCommentsPath ());
                c.DescribeAllEnumsAsStrings ();
            });
        }

        /// <summary>
        /// Registers ApiExecutor, CommandHandlers and QueryHandlers. Implementations are taken by reflection from Assembly.
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterHandlersWithDecorators (this IServiceCollection services) {
            services.AddSingleton<ApiExecutor> ();
            var handlers = typeof (ICommand).Assembly.GetTypes ()
                .Where (q => q.GetInterfaces ().Any (y => IsHandlerInterface (y)))
                .Where (x => x.Name.EndsWith ("Handler"))
                .ToList ();

            foreach (var type in handlers) {
                AddHandler (services, type);
            }
        }

        private static string GetXmlCommentsPath () {
            var app = System.AppContext.BaseDirectory;
            return System.IO.Path.Combine (app, "Borium.Webhost.xml");
        }

        private static bool IsHandlerInterface (Type type) {
            if (!type.IsGenericType)
                return false;
            var typeDefinition = type.GetGenericTypeDefinition ();
            return typeDefinition == typeof (ICommandHandler<>) || typeDefinition == typeof (IQueryHandler<,>);
        }

        private static void AddHandler (IServiceCollection services, Type type) {
            var attributes = type.GetCustomAttributes (false);
            var pipeline = attributes
                .Select (x => ToDecorator (x))
                .Concat (new [] { type })
                .Reverse ()
                .ToList ();
            var interfaceType = type.GetInterfaces ().Single (x => IsHandlerInterface (x));
            var factory = BuildPipeline (pipeline, interfaceType);
            services.AddTransient (interfaceType, factory);
        }

        private static Type ToDecorator (object attribute) {
            var type = attribute.GetType ();
            //if (type == typeof(CommandLogAtribute))
            //    return typeof(CommandLogDecorator<>);

            // other decorators/attributes goes here.
            throw new ArgumentException ($"Unknown Decorator registred: {type.Name}.");

        }

        private static Func<IServiceProvider, object> BuildPipeline (ICollection<Type> pipeline, Type interfaceType) {
            var ctors = pipeline
                .Select (q => {
                    Type type = q.IsGenericType ? q.MakeGenericType (interfaceType.GenericTypeArguments) : q;
                    return type.GetConstructors ().Single ();
                })
                .ToList ();
            Func<IServiceProvider, object> func = provider => {
                object current = null;
                foreach (ConstructorInfo ctor in ctors) {
                    List<ParameterInfo> paramsInfo = ctor.GetParameters ().ToList ();
                    object[] parameters = GetParameters (paramsInfo, current, provider);
                    current = ctor.Invoke (parameters);
                }
                return current;
            };
            return func;
        }

        private static object[] GetParameters (List<ParameterInfo> parameterInfos, object current, IServiceProvider provider) {
            var result = new object[parameterInfos.Count];
            for (int i = 0; i < parameterInfos.Count; i++) {
                result[i] = GetParamter (parameterInfos[i], current, provider);
            }
            return result;
        }

        private static object GetParamter (ParameterInfo parameterInfo, object current, IServiceProvider provider) {
            var parameterType = parameterInfo.ParameterType;

            if (IsHandlerInterface (parameterType))
                return current;

            object service = provider.GetService (parameterType);
            if (service != null)
                return service;
            throw new ArgumentException ($"The type {parameterType} not found.");
        }
    }
}