using System.ComponentModel.DataAnnotations;

namespace Pronia.DAL.ViewModels.Slider;

public class SliderItemVM
{
    [MaxLength(64), Required]
    public int Offer { get; set; }
    [MaxLength(64), Required]
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    [Required]
    public ICollection<FileInfo> Image { get; set; }
}
