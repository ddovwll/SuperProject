using Microsoft.Extensions.Primitives;
using SuperAPI.DAL;
using SuperAPI.DAL.Models;
using SuperAPI.DAL.QueryModels;

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

    public async Task<List<PostQueryModel>> GetLikedPosts(StringValues userId, StringValues sessionId)
    {
        await auth.CheckSession(userId, sessionId);
        var postsFromDb = await likesDal.GetLikedPosts(int.Parse(userId));
        var posts = postsFromDb.Select(p => new PostQueryModel()
        {
            Id = p.Id,
            Header = p.Header,
            Text = p.Text,
            LikesCount = p.LikesCount,
            UserId = p.UserId,
            UserName = p.User.NickName
        }).ToList();
        
        return posts;
    }
}