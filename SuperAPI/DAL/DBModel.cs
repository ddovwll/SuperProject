using Microsoft.EntityFrameworkCore;
using SuperAPI.DAL.Models;

namespace SuperAPI.DAL;

public class DBModel : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=32768;Database=SuperAPIDb;Username=User;Password=qwe123asd");
    }
    
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }
}