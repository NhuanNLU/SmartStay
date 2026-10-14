using SmartStay.Domain.Abstractions;

namespace SmartStay.Domain.Entities
{
    public class RoomPriceFeeMapping : DomainEntityAuditSoftDelete<int>
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int RoomPriceFeeId { get; set; }
        public RoomPriceFee RoomPriceFee { get; set; }
    }
}
