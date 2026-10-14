namespace SmartStay.Domain.Enum
{
    public enum ContractStatus
    {
        Draft = 0,           // Đang soạn
        PendingSignature = 1,// Chờ ký
        Active = 2,          // Đang hiệu lực
        Expired = 3,         // Hết hạn theo ngày kết thúc
        Terminated = 4,      // Chấm dứt trước hạn
        Cancelled = 5        // Hủy trước khi có hiệu lực
    }
}
