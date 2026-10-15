using SmartStay.Domain.Abstractions;

namespace SmartStay.Domain.Entities
{
    public class UtilityReading: DomainEntityAuditSoftDelete<int>
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public required decimal OldElectric { get; set; }
        public required decimal NewElectric { get; set; }
        public required decimal OldWater { get; set; }
        public required decimal NewWater { get; set; }
        public required decimal ElectricUnitPrice { get; set; }
        public required decimal WaterUnitPrice { get; set; }
        public required DateTime RecordingDate { get; set; }
    }
}
