namespace BabuinMarket.Domain;

public class GameCatalog
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int GameId { get; set; }
    public Game? Game { get; set; }
    public string? Genre { get; set; }
    public string[]? Tags { get; set; }

}