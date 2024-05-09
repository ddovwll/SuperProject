using System.Diagnostics.CodeAnalysis;
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

    [HttpPut("/post/update")]
    public async Task<IActionResult> UpdatePost([FromBody] Post post)
    {
        try
        {
            await postBll.UpdatePost(post, Request.Headers["UserId"], Request.Headers["SessionId"]);
        }
        catch (UnAuthException e)
        {
            return Unauthorized(e.Message);
        }
        catch(PostDataException e)
        {
            return BadRequest(e.Message);
        }

        return Ok();
    }

    [HttpGet("/post/{id:int}")]
    public async Task<IActionResult> GetPostById(int id)
    {
        Post postFromDb;
        try
        {
            postFromDb = await postBll.GetPostById(id, Request.Headers["UserId"], Request.Headers["SessionId"]);
        }
        catch (UnAuthException e)
        {
            return Unauthorized(e.Message);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }

        var post = new
        {
            Id = postFromDb.Id,
            Header = postFromDb.Header,
            Text = postFromDb.Text,
            UserId = postFromDb.UserId
        };

        return Ok(post);
    }

    [HttpGet("/post/all")]
    public async Task<IActionResult> GetPosts()
    {
        List<Post> posts;
        try
        {
            posts = await postBll.GetPosts(Request.Headers["UserId"], Request.Headers["SessionId"]);
        }
        catch (UnAuthException e)
        {
            return Unauthorized(e.Message);
        }

        return Ok(posts);
    }

    [HttpGet("/post/user/{nickname}")]
    public async Task<IActionResult> GetPostsByUser(string nickname)
    {
        List<Post> posts;
        try
        {
            posts = await postBll.GetPostsByUser(nickname, Request.Headers["UserId"], Request.Headers["SessionId"]);
        }
        catch (UnAuthException e)
        {
            return Unauthorized(e.Message);
        }
        catch (PostDataException e) 
        {
            return BadRequest(e.Message);
        }

        return Ok(posts);
    }
}