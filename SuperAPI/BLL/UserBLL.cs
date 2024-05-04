using SuperAPI.BLL.Exceptions;
using SuperAPI.DAL;
using SuperAPI.DAL.Models;

namespace SuperAPI.BLL;

public class UserBLL(IUserDAL userDAL) : IUserBLL
{
    public async Task CreateUser(User user)
    {
        var userFromDb = await userDAL.GetUserByName(user.NickName);
        if(userFromDb.Id != 0)
            throw new RegisterException(Constants.AlreadyExists);
        await userDAL.CreateUser(user);
    }

    public async Task<User> GetUserById(int id)
    {
        var userFromDb = await userDAL.GetUserById(id);
        if(userFromDb.Id == 0)
            throw new NotFoundException(Constants.NotFound);
        return userFromDb;
    }
}