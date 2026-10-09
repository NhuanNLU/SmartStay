namespace SmartStay.Domain.Abstractions.Entities
{
    public interface IDomainEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
