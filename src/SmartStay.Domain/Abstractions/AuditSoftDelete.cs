using SmartStay.Domain.Abstractions.Entities;

namespace SmartStay.Domain.Abstractions
{
    public abstract class AuditSoftDelete : IAudit, ISoftDelete
    {
        public required DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public required string CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
