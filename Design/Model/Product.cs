namespace Model;

public class Product : NewProduct
{

    public int Id { get; set; }
    public Category category { get; set; }
}

public class NewProduct : UpdateContent
{

    public int categoryId { get; set; }
    public string[] images { get; set; }
}

public class UpdateContent
{
    public string title { get; set; } = string.Empty;
    public int price { get; set; } 
    public string description { get; set; } = string.Empty;
}