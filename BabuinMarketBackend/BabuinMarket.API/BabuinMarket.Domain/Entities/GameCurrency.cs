using BabuinMarket.Domain.Entities.Abstraction;

namespace BabuinMarket.Domain.Entities;

public class GameCurrency : BaseEntity
{
    public string? Name { get; set; }
    public decimal PricePerUnit { get; set; }
    public int AvailableAmount { get; set; }
    public Guid GameId { get; set; }
    public IEnumerable<OrderItem>? OrderItems { get; set; }
}