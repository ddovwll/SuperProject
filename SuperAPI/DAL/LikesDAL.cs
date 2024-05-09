using Microsoft.EntityFrameworkCore;
using SuperAPI.DAL.Models;

namespace SuperAPI.DAL;

public class LikesDAL : ILikesDAL
{
    public async Task AddLike(Likes like)
    {
        await using var db = new DBModel();
        var post = await db.Posts.FindAsync(like.PostId);
        post.LikesCount++;
        await db.Likes.AddAsync(like);
        await db.SaveChangesAsync();
    }

    public async Task RemoveLike(int userId, int postId)
    {
        await Task.Run(async () =>
        {
            await using var db = new DBModel();
            var post = await db.Posts.FindAsync(postId);
            post.LikesCount--;
            var like = await db.Likes.FindAsync(userId, postId);
            db.Likes.Remove(like);
            await db.SaveChangesAsync();
        });
    }

    public async Task<List<Post>> GetLikedPosts(int userId)
    {
        await using var db = new DBModel();
        var likes = await db.Likes.Include(l => l.Post)
            .Where(l => l.UserId == userId).Select(l=> l.Post).ToListAsync();
        return likes;
    }
}