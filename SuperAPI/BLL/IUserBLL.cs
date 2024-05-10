using SuperAPI.DAL.Models;

namespace SuperAPI.BLL;

public interface IUserBLL
{
    Task CreateUser(User user);
    Task<User> GetUserById(int id);
    Task<string> Login(User user);
    Task<User> GetUserByName(string name);
}