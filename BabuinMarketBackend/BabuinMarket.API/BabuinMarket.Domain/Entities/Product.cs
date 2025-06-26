using BabuinMarket.Domain.Entities.Abstraction;

namespace BabuinMarket.Domain.Entities;

public class Product : BaseEntity
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? Arcticle { get; set; } 
    public string? Category { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}