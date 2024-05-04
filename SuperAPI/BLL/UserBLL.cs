using SuperAPI.BLL.Exceptions;
using SuperAPI.DAL;
using SuperAPI.DAL.Models;
using WeatherAPI.BLL;

namespace SuperAPI.BLL;

public class UserBLL(IUserDAL userDAL) : IUserBLL
{
    public async Task CreateUser(User user)
    {
        if (user == null || !user.Validate())
            throw new UserDataException(Constants.InvalidData);
        var userFromDb = await userDAL.GetUserByName(user.NickName);
        if(userFromDb.Id != 0)
            throw new RegisterException(Constants.AlreadyExists);
        IEncrypt encrypt = new Encrypt();
        user.Salt = Guid.NewGuid().ToString();
        user.Password = encrypt.HashPassword(user.Password, user.Salt);
        //TODO допилить фотки и убрать сраку снизу
        user.Photo = "qwew";
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