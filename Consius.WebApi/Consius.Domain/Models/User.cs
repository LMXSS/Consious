namespace Consius.Domain.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; } 
    public DateTime Birth { get; set; }


}
