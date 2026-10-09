using SmartStay.Domain.Abstractions;

namespace SmartStay.Domain.Entities
{
    public class RoomImage: DomainEntityAuditSoftDelete<int>
    {
        public int RoomId { get; set; }
        public required string ImageUrl { get; set; }
        public Room Room { get; set; } = null!;
    }
}
