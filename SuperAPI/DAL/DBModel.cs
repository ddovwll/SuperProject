using Microsoft.EntityFrameworkCore;
using SuperAPI.DAL.Models;

namespace SuperAPI.DAL;

public class DBModel : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=32768;Database=SuperAPIDb;Username=User;Password=qwe123asd");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Likes>().HasKey(l=> new {l.UserId, l.PostId});
    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Likes> Likes { get; set; }
}