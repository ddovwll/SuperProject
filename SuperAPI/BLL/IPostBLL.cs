using Microsoft.Extensions.Primitives;
using SuperAPI.DAL.Models;
using SuperAPI.DAL.QueryModels;

namespace SuperAPI.BLL;

public interface IPostBLL
{
    Task CreatePost(Post post, StringValues userId, StringValues sessionId);
    Task DeletePost(int id, StringValues userId, StringValues sessionId);
    Task UpdatePost(Post post, StringValues userId, StringValues sessionId);
    Task<Post> GetPostById(int id, StringValues userId, StringValues sessionId);
    Task<List<PostQueryModel>> GetPosts(StringValues userId, StringValues sessionId);
    Task<List<PostQueryModel>> GetPostsByUser(string nickname, StringValues userId, StringValues sessionId);
}