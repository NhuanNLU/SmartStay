using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class Profile : DomainEntityAuditSoftDelete<int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? AvatarUrl { get; set; }
        public Gender Gender { get; set; } = Gender.Unknown;
        public DateOnly? DateOfBirth { get; set; }
        public string? Bio { get; set; }
        public string? CoverUrl { get; set; }
        public string? FacebookUrl { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
