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
        var user = await db.Users.FindAsync(id) ?? new User();
        return user;
    }
    
    public async Task<User> GetUserByName(string name)
    {
        await using var db = new DBModel();
        var user = await db.Users.FirstOrDefaultAsync(u => u.NickName == name) ?? new User();
        return user;
    }

    public async Task UpdateUser(User user)
    {
        await Task.Run(async () =>
        {
            await using var db = new DBModel();
            db.Users.Update(user);
            await db.SaveChangesAsync();
        });
    }
}