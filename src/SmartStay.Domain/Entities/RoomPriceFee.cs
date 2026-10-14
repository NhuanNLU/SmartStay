using SmartStay.Domain.Abstractions;

namespace SmartStay.Domain.Entities
{
    public class RoomPriceFee: DomainEntityAuditSoftDelete<int>
    {
        public required string FeeName { get; set; }
        public required decimal Amount { get; set; }
    }
}
