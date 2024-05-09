using Microsoft.Extensions.Primitives;
using SuperAPI.DAL;
using SuperAPI.DAL.Models;

namespace SuperAPI.BLL;

public class LikesBLL(ILikesDAL likesDal, IAuth auth) : ILikesBLL
{
    public async Task AddLike(int postId, StringValues userId, StringValues sessionId)
    {
        await auth.CheckSession(userId, sessionId);
        var like = new Likes()
        {
            PostId = postId,
            UserId = int.Parse(userId)
        };
        
        await likesDal.AddLike(like);
    }

    public async Task RemoveLike(int postId, StringValues userId, StringValues sessionId)
    {
        await auth.CheckSession(userId, sessionId);
        await likesDal.RemoveLike(int.Parse(userId), postId);
    }

    public async Task<List<Post>> GetLikedPosts(int postId, StringValues userId, StringValues sessionId)
    {
        await auth.CheckSession(userId, sessionId);
        var posts = await likesDal.GetLikedPosts(int.Parse(userId));
        return posts;
    }
}