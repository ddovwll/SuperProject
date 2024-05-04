using Microsoft.AspNetCore.Mvc;
using SuperAPI.BLL;
using SuperAPI.BLL.Exceptions;
using SuperAPI.BLL.Mappers;
using SuperAPI.DAL.Models;
using SuperAPI.DAL.QueryModels;

namespace SuperAPI.Controllers;

[Route("/user")]
public class UserController(IUserBLL userBll) : ControllerBase
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

    [HttpGet("/{id:int}")]
    public async Task<IActionResult> GetUserById(int id)
    {
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