using Microsoft.AspNetCore.Mvc;
using SuperAPI.BLL;
using SuperAPI.BLL.Exceptions;
using SuperAPI.DAL.Models;

namespace SuperAPI.Controllers;

public class LikesController(ILikesBLL likesBll) : ControllerBase
{
    [HttpPost("/likes/{postId:int}")]
    public async Task<IActionResult> AddLike(int postId)
    {
        try
        {
            await likesBll.AddLike(postId, Request.Headers["UserId"], Request.Headers["SessionId"]);
        }
        catch (UnAuthException e)
        {
            return Unauthorized(e.Message);
        }
        catch (Exception e)
        {
            return Conflict();
        }

        return Ok();
    }

    [HttpDelete("/likes/{postId:int}")]
    public async Task<IActionResult> RemoveLike(int postId)
    {
        try
        {
            await likesBll.RemoveLike(postId, Request.Headers["UserId"], Request.Headers["SessionId"]);
        }
        catch (UnAuthException e)
        {
            return Unauthorized(e.Message);
        }

        return Ok();
    }

    [HttpGet("/likes")]
    public async Task<IActionResult> GetLikedPosts()
    {
        List<Post> likedPosts;
        try
        {
            likedPosts = await likesBll.GetLikedPosts(Request.Headers["UserId"], Request.Headers["SessionId"]);
        }
        catch (UnAuthException e)
        {
            return Unauthorized(e.Message);
        }
        
        return Ok(likedPosts);
    }
}