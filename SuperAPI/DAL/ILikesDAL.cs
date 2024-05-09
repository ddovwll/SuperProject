using SuperAPI.DAL.Models;

namespace SuperAPI.DAL;

public interface ILikesDAL
{
    Task AddLike(Likes like);
    Task RemoveLike(int userId, int postId);
    Task<List<Post>> GetLikedPosts(int userId);
}