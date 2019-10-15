using System;
using Borium.Application.Interfaces;
using Borium.Application.Utils;

namespace Borium.Webhost.Utils {
    /// <summary>
    /// Dispatcher for Queries and Commands.
    /// </summary>
    public class ApiExecutor {
        private readonly IServiceProvider _provider;

        /// <summary>
        /// Initializes new instance of ApiExecutor.
        /// </summary>
        /// <param name="serviceProvider">service provider to resolve proper CommandHandler or QueryHandler, based on its type.</param>
        public ApiExecutor (IServiceProvider serviceProvider) {
            _provider = serviceProvider;
        }

        /// <summary>
        /// Resolves proper service (ICommandHandler implementation) and executes its logic.
        /// Service is resolved based on given ICommand parameter.
        /// </summary>
        /// <param name="command">Command to execute</param>
        /// <returns></returns>
        public CommandResult Dispatch (ICommand command) {
            var handlerType = typeof (ICommandHandler<>).MakeGenericType (new [] { command.GetType () });
            dynamic handler = _provider.GetService (handlerType);
            CommandResult result = handler.Handle ((dynamic) command);
            return result;
        }

        /// <summary>
        /// Resolves proper service (IQueryHandler implementation) and executes its logic.
        /// Service is resolved based on given IQuery parameter.
        /// </summary>
        /// <param name="query">Query to execute</param>
        /// <returns></returns>
        public T Dispatch<T> (IQuery<T> query) {
            var handlerType = typeof (IQueryHandler<,>).MakeGenericType (new [] { query.GetType (), typeof (T) });
            dynamic handler = _provider.GetService (handlerType);
            T result = handler.Handle ((dynamic) query);
            return result;
        }
    }
}