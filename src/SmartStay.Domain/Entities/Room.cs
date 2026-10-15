using SmartStay.Domain.Abstractions;
using SmartStay.Domain.Enum;

namespace SmartStay.Domain.Entities
{
    public class Room : DomainEntityAuditSoftDelete<int>
    {
        public int BuildingId { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required int Floor { get; set; }
        public RoomType RoomType { get; set; }
        public required decimal Area { get; set; }
        public int? MaxOccupants { get; set; }
        public string? Description { get; set; }
        public required RoomStatus Status { get; set; } = RoomStatus.Available;

        public Building Building { get; set; }
        public ICollection<RoomPrice> RoomPrices { get; set; } = new List<RoomPrice>();
        public ICollection<RoomAmenity> RoomAmenities { get; set; } = new List<RoomAmenity>();
        public ICollection<RoomImage> RoomImages { get; set; } = new List<RoomImage>();
        public ICollection<RoomViewing> RoomViewings { get; set; } = new List<RoomViewing>();
        public ICollection<RoomManager> RoomManagers { get; set; } = new List<RoomManager>();
        public ICollection<RoomPriceMapping> RoomPriceMappings { get; set; } = new List<RoomPriceMapping>();
        public ICollection<UtilityReading> UtilityReadings { get; set; } = new List<UtilityReading>();
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
        public ICollection<Contract> Contracts { get; set; } = new List<Contract>();
        public ICollection<RoomPriceFeeMapping> RoomPriceFeeMappings { get; set; } = new List<RoomPriceFeeMapping>();
    }
}
