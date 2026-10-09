using SmartStay.Domain.Abstractions;

namespace SmartStay.Domain.Entities
{
    public class UserRole : AuditSoftDelete
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }
    }
}
