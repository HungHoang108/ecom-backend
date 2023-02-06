namespace Model;

public class User
{
    public int Id { get; init; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public string Role { get; set; } = string.Empty;
    public string Avatar { get; set; } = string.Empty;

}