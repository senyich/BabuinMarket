namespace BabuinMarket.Domain;

public class Product : Entity
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? SKU { get; set; } // Артикул
    public string? Category { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}