namespace SmartStay.Domain.Abstractions.Entities
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
