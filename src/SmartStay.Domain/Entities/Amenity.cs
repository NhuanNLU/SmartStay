using SmartStay.Domain.Abstractions;

namespace SmartStay.Domain.Entities
{
    public class Amenity : DomainEntityAuditSoftDelete<int>
    {
        public required string Name { get; set; }
        public ICollection<RoomAmenity> RoomAmenities { get; set; } = new List<RoomAmenity>();
    }
}
