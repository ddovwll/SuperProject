using SuperAPI.DAL.Models;

namespace SuperAPI.DAL;

public interface ILikesDAL
{
    Task AddLike(Likes like);
    Task RemoveLike(Likes like);
    Task<List<Post>> GetLikedPosts(int userId);
}