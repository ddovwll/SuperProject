using Microsoft.Extensions.Primitives;
using SuperAPI.DAL.Models;
using SuperAPI.DAL.QueryModels;

namespace SuperAPI.BLL;

public interface ILikesBLL
{
    Task AddLike(int postId, StringValues userId, StringValues sessionId);
    Task RemoveLike(int postId, StringValues userId, StringValues sessionId);
    Task<List<PostQueryModel>> GetLikedPosts(StringValues userId, StringValues sessionId);
}