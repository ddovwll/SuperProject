using SuperAPI.DAL.Models;
using SuperAPI.DAL.QueryModels;

namespace SuperAPI.BLL.Mappers;

public class PostQMToPost
{
    public static Post Map(PostQueryModel queryModel)
    {
        return new Post()
        {
            Header = queryModel.Header,
            Text = queryModel.Text,
            LikesCount = queryModel.LikesCount,
            UserId = queryModel.UserId
        };
    }
}