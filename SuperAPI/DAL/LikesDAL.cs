using Microsoft.EntityFrameworkCore;
using SuperAPI.DAL.Models;

namespace SuperAPI.DAL;

public class LikesDAL : ILikesDAL
{
    public async Task AddLike(Likes like)
    {
        await using var db = new DBModel();
        await db.Likes.AddAsync(like);
        await db.SaveChangesAsync();
    }

    public async Task RemoveLike(Likes like)
    {
        await Task.Run(async () =>
        {
            await using var db = new DBModel();
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