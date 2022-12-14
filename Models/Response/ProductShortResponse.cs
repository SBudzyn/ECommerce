using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class ProductShortResponse
    {
        public int Id { get; private set; }
        [Required]
        [StringLength(120, MinimumLength = 10)]
        public string Name { get; set; } = null!;
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 4)]
        public string Photo { get; set; } = null!;
        public double? Rating { get; set; }
        public int? NumberOfReviews { get; set; }
    }
}
