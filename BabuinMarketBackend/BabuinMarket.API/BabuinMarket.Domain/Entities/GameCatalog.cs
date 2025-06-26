using BabuinMarket.Domain.Entities.Abstraction;

namespace BabuinMarket.Domain.Entities;

public class GameCatalog : BaseEntity
{
    public string? Name { get; set; }
    public IEnumerable<Game> Games { get; set; }
    public string? Genre { get; set; }
}