using Microsoft.AspNetCore.Mvc;
using SuperAPI.BLL;
using SuperAPI.BLL.Exceptions;
using SuperAPI.DAL.Models;

namespace SuperAPI.Controllers;

public class PostController(IPostBLL postBll) : ControllerBase
{
    [HttpPost("/post/create")]
    public async Task<IActionResult> CreatePost([FromBody] Post post)
    {
        try
        {
            await postBll.CreatePost(post, Request.Headers["UserId"], Request.Headers["SessionId"]);
        }
        catch (UnAuthException e)
        {
            return Unauthorized(e.Message);
        }
        catch (PostDataException e)
        {
            return BadRequest(e.Message);
        }
        
        return Ok();
    }

    [HttpDelete("/post/delete/{id:int}")]
    public async Task<IActionResult> DeletePost(int id)
    {
        try
        {
            await postBll.DeletePost(id, Request.Headers["UserId"], Request.Headers["SessionId"]);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (UnAuthException e)
        {
            return Unauthorized(e.Message);
        }

        return Ok();
    }
}