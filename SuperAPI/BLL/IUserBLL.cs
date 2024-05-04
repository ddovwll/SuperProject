using SuperAPI.DAL.Models;

namespace SuperAPI.BLL;

public interface IUserBLL
{
    Task CreateUser(User user);
    Task<User> GetUserById(int id);
}