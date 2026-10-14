namespace SmartStay.Domain.Enum
{
    public enum InvoiceStatus
    {
        Draft = 0,           // Đang lập
        Issued = 1,          // Đã phát hành, chưa thanh toán đủ
        PartiallyPaid = 2,   // Đã thanh toán một phần
        Paid = 3,            // Đã thanh toán đủ
        Voided = 4           // Đã hủy hóa đơn
    }
}
