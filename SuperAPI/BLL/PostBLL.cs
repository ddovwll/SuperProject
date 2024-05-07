using SuperAPI.BLL.Exceptions;
using SuperAPI.DAL;
using SuperAPI.DAL.Models;

namespace SuperAPI.BLL;

public class PostBLL(IPostDAL postDal) : IPostBLL
{
    public async Task CreatePost(Post post)
    {
        if (!post.Validate())
            throw new PostDataException(Constants.InvalidData);
        await postDal.CreatePost(post);
    }

    public async Task DeletePost(int id)
    {
        var postFromDb = await postDal.GetPostById(id);
        if (postFromDb.Id == 0)
            throw new NotFoundException(Constants.NotFound);
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