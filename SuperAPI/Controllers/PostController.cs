using Microsoft.AspNetCore.Mvc;
using SuperAPI.BLL;
using SuperAPI.BLL.Exceptions;
using SuperAPI.DAL.Models;

namespace SuperAPI.Controllers;

public class PostController(IPostBLL postBll, IAuth auth) : ControllerBase
{
    [HttpPost("/post/create")]
    public async Task<IActionResult> CreatePost([FromBody] Post post)
    {
        try
        {
            await auth.CheckPost(Request.Headers["UserId"], Request.Headers["SessionId"], post.UserId);
        }
        catch (UnAuthException e)
        {
            return Unauthorized(e.Message);
        }

        try
        {
            await postBll.CreatePost(post);
        }
        catch (PostDataException e)
        {
            return BadRequest(e.Message);
        }
        
        return Ok();
    }
}