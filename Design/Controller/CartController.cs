namespace Controller;
using Model;

public class CartController
{
    private static List<Cart> cartItems = new List<Cart>
        {
            new Cart {
                Id = 1,
                Title = "product 1",
                Price = 25.99,
                Image = "url1",
                Quantity = 1
            },
                new Cart {
                Id = 2,
                Title = "product 2",
                Price = 20.99,
                Image = "url1",
                Quantity = 2
            }
        };
    public async Task<List<Cart>> GetAllAsync()
    {
        return cartItems;
    }

    public async Task<List<Cart>> AddAsync(Cart cartItem)
    {
        var itemIndex = cartItems.FindIndex(item => item.Id == cartItem.Id);
        if (itemIndex > 0)
        {
            cartItems.Add(cartItem);
            return cartItems;
        }
        else
        {
            cartItems[itemIndex].Quantity += 1;
            return cartItems;
        }
    }
    public void IncrementAsync(Cart cartItem)
    {
        AddAsync(cartItem);
    }
    public async Task<List<Cart>> DecrementAsync(int id)
    {
        var item = cartItems.Find(item => item.Id == id);

        if (item.Quantity == 1)
        {
            cartItems.Remove(item);
            return cartItems;
        }

        foreach (var product in cartItems)
        {
            if (product.Id == id)
            {
                product.Quantity -= 1;
            }
        }
        return cartItems;
    }

    public async Task<List<Cart>> DeleteAsync(int id)
    {
        var item = cartItems.Find(item => item.Id == id);
        cartItems.Remove(item);
        return cartItems;
    }
}