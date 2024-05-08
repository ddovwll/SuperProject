using Microsoft.Extensions.Primitives;
using SuperAPI.DAL.Models;

namespace SuperAPI.BLL;

public interface IPostBLL
{
    Task CreatePost(Post post, StringValues userId, StringValues sessionId);
    Task DeletePost(int id, StringValues userId, StringValues sessionId);
    Task UpdatePost(Post post);
    Task<Post> GetPostById(int id);
    Task<List<Post>> GetPosts(int from);
    Task<List<Post>> GetPostsByUser(string nickname);
}