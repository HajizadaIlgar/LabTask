using System.ComponentModel.DataAnnotations;

namespace MediPlus.Models
{
    public class Service : BaseEntity
    {
        [MaxLength(64), Required]
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? Icon { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
