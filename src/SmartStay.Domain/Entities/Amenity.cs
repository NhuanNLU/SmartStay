namespace SmartStay.Domain.Entities
{
    public class Amenity
    {
        public required string Name { get; set; }
        public ICollection<RoomAmenity> RoomAmenities { get; set; } = new List<RoomAmenity>();
    }
}
