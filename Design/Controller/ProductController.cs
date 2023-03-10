namespace Controller;
using Model;

public class ProductController
{
    private static List<Product> products = new List<Product>
        {
            new Product {
                Id = 1,
                Title = "product 1",
                Price = 25.99,
                Description = "hello",
                Images = new string[] {"url1", "url2", "url3"},
            },
                new Product {
                Id = 300,
                Title = "product 2",
                Price = 20.99,
                Description = "hello",
                Images = new string[] {"url1", "url2", "url3"},
            }
        };
    public async Task<List<Product>> GetAllAsync()
    {
        return products;
    }

    public async Task<List<Product>> Addsync(Product product)
    {
        products.Add(product);
        return products;
    }
    public async Task<Product> GetProductAsync(int id)
    {
        var product = products.Find(item => item.Id == id);
        if (product == null)
        {
            throw new ArgumentException("Product is not found");
        }

        return product;
    }
    public async Task<List<Product>> DeleteAsync(int id)
    {
        var product = products.Find(item => item.Id == id);
        if (product == null)
        {
            throw new ArgumentException("Product is not found");
        }
        products.Remove(product);
        return products;
    }
    public async Task<List<Product>> UpdateAsync(Product updateInfo)
    {
        int product = products.FindIndex(item => item.Id == updateInfo.Id);
        if (product == -1)
        {
            throw new ArgumentException("Product is not found");
        }
        products[product].Title = updateInfo.Title;
        products[product].Price = updateInfo.Price;
        products[product].Description = updateInfo.Description;

        return products;
    }


}