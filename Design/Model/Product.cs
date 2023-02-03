namespace Model;

public abstract class Product : NewProduct
{
    public int Id { get; set; }
    public Category category { get; set; }
}

public abstract class NewProduct : UpdateContent
{
    public int categoryId { get; set; }
    public string[] images { get; set; }
}

public abstract class UpdateContent
{
    public string title { get; set; }
    public int price { get; set; }
    public string description { get; set; }
}