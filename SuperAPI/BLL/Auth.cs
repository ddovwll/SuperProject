﻿using Microsoft.Extensions.Primitives;
using SuperAPI.BLL.Exceptions;
using SuperAPI.DAL;

namespace SuperAPI.BLL;

public class Auth (IUserDAL userDal) : IAuth
{
    public async Task CheckSession(StringValues userId, StringValues sessionId)
    {
        if(string.IsNullOrWhiteSpace(userId)|| string.IsNullOrWhiteSpace(sessionId))
            throw new UnAuthException(Constants.Unauthorized);
        var modelFromDb = await userDal.GetUserById(int.Parse(userId.ToString()));
        if (sessionId != modelFromDb.SessionId)
            throw new UnAuthException(Constants.Unauthorized);
    }

    public async Task CheckPost(StringValues userId, StringValues sessionId, int postOwnerId)
    {
        await CheckSession(userId, sessionId);
        if (postOwnerId != int.Parse(userId.ToString()))
            throw new UnAuthException(Constants.Unauthorized);
    }
}