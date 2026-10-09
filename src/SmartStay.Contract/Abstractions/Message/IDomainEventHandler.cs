using MediatR;

namespace SmartStay.Contract.Abstractions.Message
{
    public interface IDomainEventHandler : INotificationHandler<IDomainEvent>
    {
    }
}
