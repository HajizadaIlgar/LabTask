using System.ComponentModel.DataAnnotations;

namespace MediPlus.Models;

public class Slider : BaseEntity
{
	[MaxLength(64), Required]
	public string Title { get; set; }
	[MaxLength(64), Required]

	public string Description { get; set; }
	//public string? Link { get; set; }
	[Required]
	public string ImageUrl { get; set; }
}
