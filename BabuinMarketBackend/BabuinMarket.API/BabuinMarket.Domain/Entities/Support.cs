using BabuinMarket.Domain.Entities.Abstraction;

namespace BabuinMarket.Domain.Entities;

public class Support : BaseEntity
{
    public string? Subject { get; set; }
    public string? Message { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? Status { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
}