using Borium.Application.Utils;

namespace Borium.Application.Interfaces
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        CommandResult Handle(TCommand command);
    }
}
