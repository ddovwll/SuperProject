using Microsoft.Extensions.Primitives;
using SuperAPI.DAL.Models;

namespace SuperAPI.BLL;

public interface ILikesBLL
{
    Task AddLike(int postId, StringValues userId, StringValues sessionId);
    Task RemoveLike(int postId, StringValues userId, StringValues sessionId);
    Task<List<Post>> GetLikedPosts(StringValues userId, StringValues sessionId);
}