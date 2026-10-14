using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class RoomPrice : DomainEntityAuditSoftDelete<int>
    {
        public required RoomPriceStatus Status { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public decimal RentAmount { get; set; }
        public Room Room { get; set; }
    }
}
