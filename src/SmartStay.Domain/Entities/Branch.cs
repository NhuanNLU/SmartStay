using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class Branch: DomainEntityAuditSoftDelete<int>
    {
        public BranchStatus Status { get; set; }
        public required string Name { get; set; } 
        public string? Description { get; set; }

        public ICollection<BranchManager> BranchManagers { get; set; } = new List<BranchManager>();
        public ICollection<Building> Buildings { get; set; } = new List<Building>();
    }
}
