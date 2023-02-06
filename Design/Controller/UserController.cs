namespace Controller;
using Model;
using Interface;

public class UserController
{
    private static List<User> users = new List<User>
    {
            new User {
                Id = 1,
                Name = "user1",
                Email = "a@a.com",
                Password = "2",
                Role = "admin",
                Avatar = "url",
            },
                new User {
                Id = 2,
                Name = "user2",
                Email = "a1@a.com",
                Password = "2",
                Role = "cus",
                Avatar = "url",
            }
    };
    public async Task<List<User>> GetAllAsync()
    {
        return users;
    }

    public async Task<List<User>> Addsync(User user)
    {
        users.Add(user);
        return users;
    }
    public async Task<User> GetUserAsync(int id)
    {
        var user = users.Find(item => item.Id == id);
        if (user == null)
        {
            throw new ArgumentException("User is not found");
        }

        return user;
    }
    public async Task<List<User>> DeleteAsync(int id)
    {
        var user = users.Find(item => item.Id == id);
        if (user == null)
        {
            throw new ArgumentException("Product is not found");
        }
        users.Remove(user);
        return users;
    }
    public async Task<List<User>> UpdateAsync(User updateInfo)
    {
        int user = users.FindIndex(item => item.Id == updateInfo.Id);
        if (user == -1)
        {
            throw new ArgumentException("Product is not found");
        }
        users[user].Name = updateInfo.Name;
        users[user].Email = updateInfo.Email;
        users[user].Password = updateInfo.Password;
        users[user].Role = updateInfo.Role;
        users[user].Avatar = updateInfo.Avatar;
        return users;
    }
}
