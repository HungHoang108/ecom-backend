namespace Model;

public class Cart
{
    public int Id { get; init; }
    public string Title { get; set; } = string.Empty;
    public double Price {get; set;}
    public string Image {get; set;} = string.Empty;
    public int Quantity {get; set;}
}