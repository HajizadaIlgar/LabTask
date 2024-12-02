using System.ComponentModel.DataAnnotations;

namespace MediPlus.ViewModels
{
    public class SliderVM
    {
        [MaxLength(32, ErrorMessage = "Uzunluq maksimum 32 ola biler"), Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        //public string? Link { get; set; }

        [Required(ErrorMessage = "Fayl duzgun formatta secilmeyib")]
        public IFormFile File { get; set; }
    }
}
