namespace Model;

public class Product
{
    public int Id { get; init; }
    public string Title { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string[] Images { get; set; }
}

