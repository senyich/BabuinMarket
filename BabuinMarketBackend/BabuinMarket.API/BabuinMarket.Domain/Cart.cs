namespace BabuinMarket.Domain;

public class Cart
{
    public int UserId { get; set; }
    public List<CartItem> Items { get; set; } = new();

    public decimal Total => Items.Sum(item => item.TotalPrice);
}