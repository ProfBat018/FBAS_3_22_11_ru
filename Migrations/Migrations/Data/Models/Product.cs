namespace Migrations;

public class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Name { get; set; }
}
