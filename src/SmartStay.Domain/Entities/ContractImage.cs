using SmartStay.Domain.Abstractions;

namespace SmartStay.Domain.Entities
{
    public class ContractImage: DomainEntityAuditSoftDelete<int>
    {
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
        public required string ImageUrl { get; set; }
    }
}
