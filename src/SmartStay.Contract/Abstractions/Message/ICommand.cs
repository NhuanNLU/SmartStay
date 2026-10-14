using MediatR;
using SmartStay.Contract.Abstractions.Shared;

namespace SmartStay.Contract.Abstractions.Message
{
    public interface ICommand : IRequest<Result>
    {
    }
    public interface ICommand<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
