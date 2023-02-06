namespace Controller;
using Model;

public class CategoryController
{
    private static List<Category> categories = new List<Category>
    {
            new Category {
                Id = 1,
                Name = "product 1",
            },
                new Category {
                Id = 2,
                Name = "product 2",
            }
    };
    public async Task<List<Category>> GetAllAsync()
    {
        return categories;
    }
}
