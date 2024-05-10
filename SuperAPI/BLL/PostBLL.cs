using Microsoft.Extensions.Primitives;
using SuperAPI.BLL.Exceptions;
using SuperAPI.DAL;
using SuperAPI.DAL.Models;
using SuperAPI.DAL.QueryModels;

namespace SuperAPI.BLL;

public class PostBLL(IPostDAL postDal, IAuth auth) : IPostBLL
{
    public async Task CreatePost(Post post, StringValues userId, StringValues sessionId)
    {
        if (!post.Validate())
            throw new PostDataException(Constants.InvalidData);
        await auth.CheckPost(userId, sessionId, post.UserId);
        await postDal.CreatePost(post);
    }

    public async Task DeletePost(int id, StringValues userId, StringValues sessionId)
    {
        var postFromDb = await postDal.GetPostById(id);
        if (postFromDb.Id == 0)
            throw new NotFoundException(Constants.NotFound);
        await auth.CheckPost(userId, sessionId, postFromDb.UserId);
        await postDal.DeletePost(id);
    }

    public async Task UpdatePost(Post post, StringValues userId, StringValues sessionId)
    {
        var postFromDb = await postDal.GetPostById(post.Id);
        await auth.CheckPost(userId, sessionId, postFromDb.UserId); 
        if (!post.Validate())
            throw new PostDataException(Constants.InvalidData);
        post.UserId = postFromDb.UserId;
        post.LikesCount = postFromDb.LikesCount;
        await postDal.UpdatePost(post);
    }

    public async Task<Post> GetPostById(int id, StringValues userId, StringValues sessionId)
    {
        await auth.CheckSession(userId, sessionId);
        var postFromDb = await postDal.GetPostById(id);
        if (postFromDb.Id == 0)
            throw new NotFoundException(Constants.NotFound);
        return postFromDb;
    }

    public async Task<List<PostQueryModel>> GetPosts(StringValues userId, StringValues sessionId)
    {
        await auth.CheckSession(userId, sessionId);
        var postsFromDb = await postDal.GetPosts();
        var posts = postsFromDb.Select(p => new PostQueryModel()
        {
            Id = p.Id,
            Header = p.Header,
            Text = p.Text,
            LikesCount = p.LikesCount,
            UserId = p.UserId
        }).OrderByDescending(p=>p.Id).ToList();
        return posts;
    }

    public async Task<List<PostQueryModel>> GetPostsByUser(string nickname, StringValues userId, StringValues sessionId)
    {
        await auth.CheckSession(userId, sessionId);
        if(string.IsNullOrWhiteSpace(nickname))
            throw new PostDataException(Constants.InvalidData);
        var postsFromDb = await postDal.GetPostsByUser(nickname);
        var posts = postsFromDb.Select(p => new PostQueryModel()
        {
            Id = p.Id,
            Header = p.Header,
            Text = p.Text,
            LikesCount = p.LikesCount,
            UserId = p.UserId
        }).ToList();
        return posts;
    }
}