namespace SuperAPI.DAL.Models;

public class Post
{
    public int Id { get; set; }
    public string Header { get; set; }
    public string Text { get; set; }
    public int LikesCount { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }

    public bool Validate()
    {
        return !string.IsNullOrWhiteSpace(Header) && !string.IsNullOrWhiteSpace(Text);
    }
}