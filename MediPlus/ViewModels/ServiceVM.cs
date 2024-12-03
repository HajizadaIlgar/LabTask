using System.ComponentModel.DataAnnotations;

namespace MediPlus.ViewModels;

public class ServiceVM
{
	public int Id { get; set; }
	[MaxLength(64), Required]
	public string Title { get; set; } = null!;
	public string Description { get; set; } = null!;
	public string? Icon { get; set; }
}
