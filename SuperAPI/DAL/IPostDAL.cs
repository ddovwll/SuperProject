using SuperAPI.DAL.Models;
using SuperAPI.DAL.QueryModels;

namespace SuperAPI.DAL;

public interface IPostDAL
{
    Task CreatePost(Post post);
    Task DeletePost(int id);
    Task UpdatePost(Post post);
    Task<Post> GetPostById(int id);
    Task<List<Post>> GetPosts();
    Task<List<Post>> GetPostsByUser(string nickname);
    Task CheckLike(int userId, PostQMWithLike post);
}