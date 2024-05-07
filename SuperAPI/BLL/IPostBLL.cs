using SuperAPI.DAL.Models;

namespace SuperAPI.BLL;

public interface IPostBLL
{
    Task CreatePost(Post post);
    Task DeletePost(int id);
    Task UpdatePost(Post post);
    Task<Post> GetPostById(int id);
    Task<List<Post>> GetPosts(int from);
    Task<List<Post>> GetPostsByUser(string nickname);
}