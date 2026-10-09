using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class RoomViewing : DomainEntityAuditSoftDelete<int>
    {
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public DateTime ScheduledAt { get; set; }
        public string? CustomerNote { get; set; }
        public RoomViewingResult Result { get; set; }
        public int AttendeeCount { get; set; }
        public RoomViewingStatus Status { get; set; }
        public User User { get; set; }
        public Room Room { get; set; }
    }
}
