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
        user.SessionId = 0.ToString();
        await userDAL.CreateUser(user);
    }

    public async Task<string> Login(User user)
    {
        if (user == null || !user.Validate())
            throw new UserDataException(Constants.InvalidData);
        var modelFromDb = await userDAL.GetUserByName(user.NickName);
        if (modelFromDb.Id == 0)
            throw new NotFoundException(Constants.NotFound);
        IEncrypt encrypt = new Encrypt();
        if (modelFromDb.Password != encrypt.HashPassword(user.Password, modelFromDb.Salt))
            throw new UserDataException(Constants.InvalidData);
        modelFromDb.SessionId = Guid.NewGuid().ToString();
        await userDAL.UpdateUser(modelFromDb);
        return modelFromDb.SessionId;
    }

    public async Task<User> GetUserById(int id)
    {
        var userFromDb = await userDAL.GetUserById(id);
        if(userFromDb.Id == 0)
            throw new NotFoundException(Constants.NotFound);
        return userFromDb;
    }

    public async Task<User> GetUserByName(string name)
    {
        var userFromDb = await userDAL.GetUserByName(name);
        if(userFromDb.Id == 0)
            throw new NotFoundException(Constants.NotFound);
        return userFromDb;
    }
}