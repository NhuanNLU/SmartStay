using MediatR;
using SmartStay.Contract.Abstractions.Shared;

namespace SmartStay.Contract.Abstractions.Message
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
