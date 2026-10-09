using SmartStay.Domain.Abstractions.Entities;

namespace SmartStay.Domain.Abstractions
{
    public abstract class DomainEntityAuditSoftDelete<TKey> : IDomainEntity<TKey>, IAudit, ISoftDelete
    {
        public required TKey Id { get; set; }
        public required DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public required string CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
