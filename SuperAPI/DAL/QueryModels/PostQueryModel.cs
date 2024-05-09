namespace SuperAPI.DAL.QueryModels;

public class PostQueryModel
{
    public int Id { get; set; }
    public string Header { get; set; }
    public string Text { get; set; }
    public int LikesCount { get; set; }
    public int UserId { get; set; }
}