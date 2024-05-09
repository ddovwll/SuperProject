using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;
using SuperAPI.BLL;
using SuperAPI.BLL.Exceptions;
using SuperAPI.BLL.Mappers;
using SuperAPI.DAL.Models;
using SuperAPI.DAL.QueryModels;

namespace SuperAPI.Controllers;

public class PostController(IPostBLL postBll) : ControllerBase
{
    [HttpPost("/post/create")]
    public async Task<IActionResult> CreatePost([FromBody] PostQueryModel post)
    {
        Post postModel;
        try
        {
            postModel = PostQMToPost.Map(post);
            await postBll.CreatePost(postModel, Request.Headers["UserId"], Request.Headers["SessionId"]);
        }
        catch (UnAuthException e)
        {
            return Unauthorized(e.Message);
        }
        catch (PostDataException e)
        {
            return BadRequest(e.Message);
        }

        var responseModel = new
        {
            Id = postModel.Id,
            Heder = postModel.Header,
            Text = postModel.Text,
            Likes = postModel.LikesCount,
            UserId = postModel.UserId
        };
        
        return Ok(responseModel);
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
    public async Task<IActionResult> UpdatePost([FromBody] PostQueryModel post)
    {
        Post postModel;
        
        try
        {
            postModel = PostQMToPost.Map(post);
            await postBll.UpdatePost(postModel, Request.Headers["UserId"], Request.Headers["SessionId"]);
        }
        catch (UnAuthException e)
        {
            return Unauthorized(e.Message);
        }
        catch(PostDataException e)
        {
            return BadRequest(e.Message);
        }
        
        var responseModel = new
        {
            Id = postModel.Id,
            Header = postModel.Header,
            Text = postModel.Text,
            LikesCount = postModel.LikesCount,
            UserId = postModel.UserId
        };

        return Ok(responseModel);
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
            LikesCount = postFromDb.LikesCount,
            UserId = postFromDb.UserId
        };

        return Ok(post);
    }

    [HttpGet("/post/all")]
    public async Task<IActionResult> GetPosts()
    {
        List<PostQueryModel> posts;
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
        List<PostQueryModel> posts;
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