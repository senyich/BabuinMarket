namespace BabuinMarket.Domain.Entities.Abstraction;

public class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
}