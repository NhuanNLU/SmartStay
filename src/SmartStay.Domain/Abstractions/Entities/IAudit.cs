namespace SmartStay.Domain.Abstractions.Entities
{
    public interface IAudit
    {
        DateTimeOffset CreatedAt { get; set; }
        DateTimeOffset? UpdatedAt { get; set; }
        string CreatedBy { get; set; }
        string? UpdatedBy { get; set; }
    }
}
