using SuperAPI.DAL.Models;

namespace SuperAPI.DAL;

public interface IPostDAL
{
    Task CreatePost(Post post);
    Task DeletePost(int id);
    Task UpdatePost(Post post);
    Task<Post> GetPostById(int id);
    Task<List<Post>> GetPosts();
    Task<List<Post>> GetPostsByUser(string nickname);
}