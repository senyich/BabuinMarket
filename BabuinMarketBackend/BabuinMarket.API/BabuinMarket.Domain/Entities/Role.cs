using BabuinMarket.Domain.Entities.Abstraction;

namespace BabuinMarket.Domain.Entities;

public class Role : BaseEntity
{
    public string? Name { get; set; }
    public IEnumerable<User>? Users { get; set; }
}