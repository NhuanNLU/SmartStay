using MediatR;
using SmartStay.Contract.Abstractions.Shared;

namespace SmartStay.Contract.Abstractions.Message
{
    public interface ICommandHandler<TCommand> :
        IRequestHandler<TCommand, Result>
        where TCommand : ICommand
    {
    }
    public interface ICommandHandler<TCommand, TResponse> :
        IRequestHandler<TCommand, Result<TResponse>>
        where TCommand : ICommand<TResponse>
    {
    }
}
