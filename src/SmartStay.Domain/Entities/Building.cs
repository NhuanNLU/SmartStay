using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class Building: DomainEntityAuditSoftDelete<int>
    {
        public int BranchId { get; set; }
        public required string Address { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public BuildingType BuildingType { get; set; }
        public int FloorCount { get; set; }
        public BuildingStatus Status { get; set; }

        public Branch Branch { get; set; } 
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
