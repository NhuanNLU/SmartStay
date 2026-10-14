using SmartStay.Domain.Abstractions;

namespace SmartStay.Domain.Entities
{
    public class Role: DomainEntityAuditSoftDelete<int>
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
