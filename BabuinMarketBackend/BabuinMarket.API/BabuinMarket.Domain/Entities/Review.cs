using BabuinMarket.Domain.Entities.Abstraction;

namespace BabuinMarket.Domain.Entities;

public class Review : BaseEntity
{
    public string? Comment { get; set; }
    public int Rating { get; set; }
    public DateTime ReviewDate { get; set; }
    public User? User { get; set; }
    public Guid GameId { get; set; }
    public Game? Game { get; set; }
}