using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class User : DomainEntityAuditSoftDelete<int>
    {
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public UserStatus Status { get; set; } = UserStatus.Unverified;
        public required string Email { get; set; }
        public bool EmailVerified { get; set; } = false;
        public string? StaffCode { get; set; }
        public Profile? Profile { get; set; }
        public ICollection<BranchManager> BranchManagers { get; set; } = new List<BranchManager>();
        public ICollection<RoomManager> RoomManagers { get; set; } = new List<RoomManager>();
        public ICollection<RoomViewing> RoomViewings { get; set; } = new List<RoomViewing>();
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
