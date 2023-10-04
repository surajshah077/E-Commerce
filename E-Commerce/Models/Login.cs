using E_Commerce.Models.Enum;
namespace E_Commerce.Models;

public class Login
{
    public string Email { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
}
