namespace BabuinMarket.Domain;

public class Review
{
    public int Id { get; set; }
    public string? Comment { get; set; }
    public int Rating { get; set; }
    public DateTime ReviewDate { get; set; }
    public User? User { get; set; }
    public int GameId { get; set; }
    public Game? Game { get; set; }
}