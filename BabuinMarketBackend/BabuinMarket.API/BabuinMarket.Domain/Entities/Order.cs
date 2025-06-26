using BabuinMarket.Domain.Entities.Abstraction;
using BabuinMarket.Domain.Enums;

namespace BabuinMarket.Domain.Entities;

public class Order : BaseEntity
{
    public int? OrderNumber { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public int UserId { get; set; }
    public User? User { get; set; }
    public IEnumerable<OrderItem> Items { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.New;
    public PaymentMethod PaymentMethod { get; set; }
}