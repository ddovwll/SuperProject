using Microsoft.AspNetCore.Mvc;
using SuperAPI.BLL;
using SuperAPI.BLL.Exceptions;
using SuperAPI.BLL.Mappers;
using SuperAPI.DAL.Models;
using SuperAPI.DAL.QueryModels;

namespace SuperAPI.Controllers;

public class UserController(IUserBLL userBll, IAuth auth) : ControllerBase
{
    [HttpPost("/register")]
    public async Task<IActionResult> Register([FromBody] RegistrationQueryModel user)
    {
        try
        {
            await userBll.CreateUser(RegistrationQMToUserModel.Map(user));
        }
        catch(UserDataException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (RegisterException ex)
        {
            return Conflict(ex.Message);
        }

        return Ok();
    }

    [HttpPost("/login")]
    public async Task<IActionResult> Login([FromBody] RegistrationQueryModel user)
    {
        string sessionId;
        User userFromDb;

        try
        {
            sessionId = await userBll.Login(RegistrationQMToUserModel.Map(user));
            userFromDb = await userBll.GetUserByName(user.NickName);
        }
        catch (UserDataException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (NotFoundException ex) 
        {
            return NotFound(ex.Message);
        }

        var responseModel = new
        {
            UserId = userFromDb.Id,
            SessionId = sessionId
        };
        
        return Ok(responseModel);
    }

    [HttpGet("/user/{id:int}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        try
        {
            await auth.CheckSession(Request.Headers["UserId"], Request.Headers["SessionId"]);
        }
        catch (UnAuthException ex)
        {
            return Unauthorized(ex.Message);
        }
        
        User user;
        try
        {
            user = await userBll.GetUserById(id);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }

        var responseModel = new
        {
            Id = user.Id,
            NickName = user.NickName
        };
        
        return Ok(responseModel);
    }
}