
using Store.Domain.Commands.Interfaces;

namespace Store.Domain.Handlers.Interfaces
{
    public interface IHandlers<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
