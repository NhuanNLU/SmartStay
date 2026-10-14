using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class RoomAmenity : AuditSoftDelete
    {
        public int AmenityId { get; set; }                                      
        public int RoomId { get; set; }
        public int Quantity { get; set; }
        public RoomAmenityStatus Status { get; set; }

        public Amenity Amenity { get; set; }
        public Room Room { get; set; }
    }
}
