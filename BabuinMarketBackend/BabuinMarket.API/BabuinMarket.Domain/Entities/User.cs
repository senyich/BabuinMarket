using BabuinMarket.Domain.Entities.Abstraction;

namespace BabuinMarket.Domain.Entities;

public class User : BaseEntity
{
    public string? UserName { get; set; }
    public Guid RoleId { get; set; }
    public Role? Role { get; set; }
    public string? Email { get; set; }
    public decimal Balance { get; set; }
    public bool IsVerified { get; set; } = false;
    public IEnumerable<Order>? Orders { get; set; }
}