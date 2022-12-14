using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public abstract class ProductFullResponse
    {
        public int Id { get; private set; }
        [Required]
        [StringLength(120, MinimumLength = 10)]
        public string Name { get; set; } = null!;
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string? ManufacturerName { get; set; }
        public string? SeriaName { get; set; }
        public List<string> Photos { get; set; } = new();
        [Range(2000, 2030)]
        public int? Year { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Color { get; set; } = null!;
        public string? Description { get; set; }
        public double? Rating { get; set; }
        public int? NumberOfReviews { get; set; }
        public List<ReviewResponse> Reviews { get; set; } = new();
    }
}
