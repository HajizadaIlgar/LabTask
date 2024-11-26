using System.ComponentModel.DataAnnotations;

namespace Pronia.DAL.Models;

public class SliderItem : BaseEntity
{
    [MaxLength(64), Required]
    public int Offer { get; set; }
    [MaxLength(64), Required]
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    [Required]
    public string ImgPath { get; set; }
}
