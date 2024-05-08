using Microsoft.Extensions.Primitives;
using SuperAPI.BLL.Exceptions;
using SuperAPI.DAL;
using SuperAPI.DAL.Models;

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

    public async Task UpdatePost(Post post)
    {
        if (!post.Validate())
            throw new PostDataException(Constants.InvalidData);
        await postDal.UpdatePost(post);
    }

    public async Task<Post> GetPostById(int id)
    {
        var postFromDb = await postDal.GetPostById(id);
        if (postFromDb.Id == 0)
            throw new NotFoundException(Constants.NotFound);
        return postFromDb;
    }

    public async Task<List<Post>> GetPosts(int from)
    {
        if(from<0)
            throw new PostDataException(Constants.InvalidData);
        var postsFromDb = await postDal.GetPosts(from);
        return postsFromDb;
    }

    public async Task<List<Post>> GetPostsByUser(string nickname)
    {
        if(string.IsNullOrWhiteSpace(nickname))
            throw new PostDataException(Constants.InvalidData);
        var postsFromDb = await postDal.GetPostsByUser(nickname);
        return postsFromDb;
    }
}