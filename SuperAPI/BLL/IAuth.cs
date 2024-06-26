﻿using Microsoft.Extensions.Primitives;

namespace SuperAPI.BLL;

public interface IAuth
{
    Task CheckSession(StringValues userId, StringValues sessionId);
    Task CheckPost(StringValues userId, StringValues sessionId, int postOwnerId);
}