using Microsoft.Extensions.Options;

namespace SuperAPI.DAL.Models;

public class User
{
    public int Id { get; set; }
    public string NickName { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public string SessionId { get; set; }
    
    public bool Validate()
    {
        if (string.IsNullOrWhiteSpace(NickName) || string.IsNullOrWhiteSpace(Password))
            return false;
        return true;
    }
}