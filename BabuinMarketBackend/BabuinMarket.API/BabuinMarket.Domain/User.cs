namespace BabuinMarket.Domain;

public class User
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public int RoleId { get; set; } = 0;
    public Role? Role { get; set; }
    public string? Email { get; set; }
    public decimal Balance { get; set; } = 0;
    public bool IsVerified { get; set; } = false;
    public List<Order>? Orders { get; set; }
}