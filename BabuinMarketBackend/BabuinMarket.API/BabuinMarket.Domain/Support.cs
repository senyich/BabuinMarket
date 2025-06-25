namespace BabuinMarket.Domain;

public class Support
{
    public int Id { get; set; }
    public string? Subject { get; set; }
    public string? Message { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? Status { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
}