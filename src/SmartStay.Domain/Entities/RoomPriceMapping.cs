using SmartStay.Domain.Abstractions;

namespace SmartStay.Domain.Entities
{
    public class RoomPriceMapping: DomainEntityAuditSoftDelete<int>
    {
        public int RoomId { get; set; }
        public Room Room { get; set; } 
        public int RoomPriceId { get; set; }
        public RoomPrice RoomPrice { get; set; } 
    }
}
