using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class Room : DomainEntityAuditSoftDelete<int>
    {
        public int BuildingId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Floor { get; set; }
        public RoomType RoomType { get; set; }
        public decimal Area { get; set; }
        public int MaxOccupants { get; set; }
        public string? Description { get; set; }
        public RoomStatus Status { get; set; }

        public Building Building { get; set; } = null!;
        public ICollection<RoomPrice> RoomPrices { get; set; } = new List<RoomPrice>();
        public ICollection<RoomAmenity> RoomAmenities { get; set; } = new List<RoomAmenity>();
        public ICollection<RoomImage> RoomImages { get; set; } = new List<RoomImage>();
        public ICollection<RoomViewing> RoomViewings { get; set; } = new List<RoomViewing>();
        public ICollection<RoomManager> RoomManagers { get; set; } = new List<RoomManager>();
    }
}
