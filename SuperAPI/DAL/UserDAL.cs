using Microsoft.EntityFrameworkCore;
using SuperAPI.DAL.Models;

namespace SuperAPI.DAL;

public class UserDAL : IUserDAL
{
    public async Task CreateUser(User user)
    {
        await using var db = new DBModel();
        await db.Users.AddAsync(user);
        await db.SaveChangesAsync();
    }

    public async Task<User> GetUserById(int id)
    {
        await using var db = new DBModel();
        var user = await db.Users.FirstOrDefaultAsync(x => x.Id == id) ?? new User();
        return user;
    }
}