using System.ComponentModel.DataAnnotations;

namespace GameStoreMVC.ViewModels.Auths;

public class RegisterVM
{
    [MaxLength(100), Required]
    public string FirstName { get; set; } = null!;
    [MaxLength(100), Required]
    public string LastName { get; set; } = null!;
    [MaxLength(100), Required]
    public string UserName { get; set; } = null!;
    [MaxLength(32), DataType(DataType.EmailAddress)]
    public string EmailAddress { get; set; }
    [MaxLength(32), DataType(DataType.Password)]
    public string Password { get; set; }
    [MaxLength(32), DataType(DataType.Password), Compare(nameof(Password))]
    public string RePassword { get; set; }
}
