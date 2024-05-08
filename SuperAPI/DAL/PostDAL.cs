using Microsoft.EntityFrameworkCore;
using SuperAPI.DAL.Models;

namespace SuperAPI.DAL;

public class PostDAL : IPostDAL
{
    public async Task CreatePost(Post post)
    {
        await using var db = new DBModel();
        await db.Posts.AddAsync(post);
        await db.SaveChangesAsync();
    }

    public async Task DeletePost(int id)
    {
        await Task.Run(async () =>
        {
            await using var db = new DBModel();
            db.Posts.Remove(await GetPostById(id));
            await db.SaveChangesAsync();
        });
    }

    public async Task UpdatePost(Post post)
    {
        await Task.Run(async () =>
        {
            await using var db = new DBModel();
            db.Posts.Update(post);
            await db.SaveChangesAsync();
        });        
    }

    public async Task<Post> GetPostById(int id)
    {
        await using var db = new DBModel();
        var post = await db.Posts.FindAsync(id) ?? new Post();
        return post;
    }

    public async Task<List<Post>> GetPosts()
    {
        await using var db = new DBModel();
        var posts = await db.Posts.ToListAsync();
        return posts;
    }

    public async Task<List<Post>> GetPostsByUser(string nickname)
    {
        await using var db = new DBModel();
        var posts = await db.Posts.Where(p=>p.User.NickName == nickname).ToListAsync();
        return posts;
    }
}