using Microsoft.AspNetCore.Identity;

namespace GameStoreMVC.Models;

public class User : IdentityUser
{
    public string FullName { get; set; }
    public string? Address { get; set; } = null;
    public string? ProfileImageUrl { get; set; } = null;
}
