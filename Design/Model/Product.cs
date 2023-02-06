namespace Model;

public class Product : UpdateContent
{
    public int Id { get; set; }
    public string category { get; set; }
    public string[] images { get; set; }
}

public class UpdateContent
{
    public string title { get; set; } = string.Empty;
    public int price { get; set; } 
    public string description { get; set; } = string.Empty;
}