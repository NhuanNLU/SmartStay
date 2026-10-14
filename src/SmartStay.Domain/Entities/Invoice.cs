using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class Invoice: DomainEntityAuditSoftDelete<int>
    {
        public required string InvoiceCode { get; set; }
        public required string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public InvoiceStatus Status { get; set; }
        public string? Note { get; set; }
    }
}
