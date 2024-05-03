namespace SuperAPI.DAL.Models;

public class User
{
    public int Id { get; set; }
    public string NickName { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public string Photo { get; set; }
    public List<Post> Posts { get; set; } = new List<Post>();
    public List<int> LikedPosts { get; set; } = new List<int>();
}