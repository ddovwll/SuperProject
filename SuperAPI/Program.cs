using SuperAPI.BLL;
using SuperAPI.DAL;

namespace SuperAPI;

public class Program
{
    public static void Main(string[] args)
    {
        /*using var db = new DBModel();
        
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();*/
        
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthorization();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddControllers();

        builder.Services.AddSingleton<IUserDAL, UserDAL>();
        builder.Services.AddScoped<IUserBLL, UserBLL>();
        builder.Services.AddScoped<IAuth, Auth>();
        builder.Services.AddSingleton<IPostDAL, PostDAL>();
        builder.Services.AddScoped<IPostBLL, PostBLL>();
        builder.Services.AddSingleton<ILikesDAL, LikesDAL>();
        builder.Services.AddScoped<ILikesBLL, LikesBLL>();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();
        
        app.UseEndpoints(endpoints => { endpoints.MapControllers();});
        
        app.Run();
    }
}