using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class RoomManager: AuditSoftDelete
    {
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public RoomManagerStatus Status { get; set; }
        public User User { get; set; }
        public Room Room { get; set; }
    }
}
