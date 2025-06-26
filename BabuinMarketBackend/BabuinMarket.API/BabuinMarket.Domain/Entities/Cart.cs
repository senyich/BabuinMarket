using BabuinMarket.Domain.Entities.Abstraction;

namespace BabuinMarket.Domain.Entities;

public class Cart : BaseEntity
{
    public Guid UserId { get; set; }
    public User? User { get; set; }
}