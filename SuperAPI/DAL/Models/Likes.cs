using System.ComponentModel.DataAnnotations;

namespace SuperAPI.DAL.Models;

public class Likes
{
    [Key]
    public int UserId { get; set; }
    public Post Post { get; set; }
}