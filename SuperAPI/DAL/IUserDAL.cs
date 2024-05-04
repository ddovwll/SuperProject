using SuperAPI.DAL.Models;

namespace SuperAPI.DAL;

public interface IUserDAL
{
    Task CreateUser(User user);
    Task<User> GetUserById(int id);
    Task<User> GetUserByName(string name);
}