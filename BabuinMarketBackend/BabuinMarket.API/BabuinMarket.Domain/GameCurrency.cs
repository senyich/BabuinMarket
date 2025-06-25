namespace BabuinMarket.Domain;

public class GameCurrency
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal PricePerUnit { get; set; }
    public int AvailableAmount { get; set; }
    public int GameId { get; set; }
    public List<OrderItem>? OrderItems { get; set; }
}