namespace BabuinMarket.Domain;

public class User
{

    public int Id { get; set; }
    public string? UserName { get; set; }
    public List<Role>? Roles{ get; set; }
    public string? Email { get; set; }
}