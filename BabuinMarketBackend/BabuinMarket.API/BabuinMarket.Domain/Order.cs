namespace BabuinMarket.Domain;

public class Order : Entity
{
    public string? OrderNumber { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Связи
    public int UserId { get; set; }
    public User? User { get; set; }
    public List<OrderItem> Items { get; set; } = new();

    // Статус
    public OrderStatus Status { get; set; } = OrderStatus.New;

    // Оплата
    public PaymentMethod PaymentMethod { get; set; }

    // Итоги
    public decimal Total => Items.Sum(item => item.TotalPrice);
}