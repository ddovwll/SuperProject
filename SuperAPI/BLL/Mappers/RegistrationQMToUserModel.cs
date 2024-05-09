using SuperAPI.DAL.Models;
using SuperAPI.DAL.QueryModels;

namespace SuperAPI.BLL.Mappers;

public static class RegistrationQMToUserModel
{
    public static User Map(RegistrationQueryModel queryModel)
    {
        return new User()
        {
            NickName = queryModel.NickName,
            Password = queryModel.Password
        };
    }
}