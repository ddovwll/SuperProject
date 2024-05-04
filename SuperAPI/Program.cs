using SuperAPI.BLL;
using SuperAPI.DAL;

namespace SuperAPI;

public class Program
{
    public static void Main(string[] args)
    {
        using var db = new DBModel();
        
        db.Database.EnsureCreated();
        
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthorization();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddSingleton<IUserDAL, UserDAL>();
        builder.Services.AddScoped<IUserBLL, UserBLL>();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();
        
        app.Run();
    }
}