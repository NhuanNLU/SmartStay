using SmartStay.Domain.Abstractions;

namespace SmartStay.Domain.Entities
{
    public class UtilityReading: DomainEntityAuditSoftDelete<int>
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public decimal OldElectric { get; set; }
        public decimal NewElectric { get; set; }
        public decimal OldWater { get; set; }
        public decimal NewWater { get; set; }
        public decimal ElectricUnitPrice { get; set; }
        public decimal WaterUnitPrice { get; set; }
        public DateTime RecordingDate { get; set; }
    }
}
