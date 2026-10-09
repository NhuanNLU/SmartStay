using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class RoomPrice: DomainEntityAuditSoftDelete<int>
    {
        public int RoomId { get; set; }
        public required RoomPriceStatus Status { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public decimal RentAmount { get; set; }
        public decimal InternetFee { get; set; }
        public decimal ParkingFee { get; set; }
        public decimal GarbageFee { get; set; }
        public decimal ServiceFee { get; set; }

        public Room Room { get; set; }
    }
}
