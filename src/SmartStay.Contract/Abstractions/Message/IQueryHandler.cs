using MediatR;
using SmartStay.Contract.Abstractions.Shared;

namespace SmartStay.Contract.Abstractions.Message
{
    public interface IQueryHandler<TQuery, TResponse> :
        IRequestHandler<TQuery, Result<TResponse>>
        where TQuery : IQuery<TResponse>
    {
    }
}
