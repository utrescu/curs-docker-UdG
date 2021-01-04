using System.ComponentModel.DataAnnotations;

namespace Colors.Models
{
    public class Color
    {
        public long Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^#[0-9a-f]{6}$",
         ErrorMessage = "Rgb format incorrect must be like: #fa1234")]
        public string Rgb { get; set; }
    }
}