namespace Migrations;

public class User
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Email { get; set; }

    public string Password { get; set; }
}

