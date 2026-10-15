using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class RoomPrice : DomainEntityAuditSoftDelete<int>
    {
        public required RoomPriceStatus Status { get; set; } = RoomPriceStatus.Draft;
        public required DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public required decimal RentAmount { get; set; }
        public ICollection<RoomPriceMapping> RoomPriceMappings { get; set; } = new List<RoomPriceMapping>();
    }
}
