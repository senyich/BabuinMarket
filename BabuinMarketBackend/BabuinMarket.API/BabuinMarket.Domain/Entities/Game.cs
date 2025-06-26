using BabuinMarket.Domain.Entities.Abstraction;

namespace BabuinMarket.Domain.Entities;

public class Game : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public string? BackroundImageUrl { get; set; }
    public Guid CatalogId { get; set; }
    public GameCatalog Catalog { get; set; }
    public IEnumerable<GameCurrency>? Currencies { get; set; }
}