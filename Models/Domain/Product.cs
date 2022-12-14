using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    [Table("Products")]
    public abstract class Product
    {
        public Product()
        {

        }
        public Product(string name, string color, decimal price, string photos, Manufacturer? manufacturer = null, int? year = null, string? description = null)
        {
            Name = name;
            Color = color;
            Price = price;
            Manufacturer = manufacturer;
            Photos = photos;
            Year = year;
            Description = description;
        }
        public int Id { get; private set; }
        [Required]
        [StringLength(120, MinimumLength = 10)]
        public string Name { get; set; } = null!;
        public int? SeriaId { get; set; }
        public Seria? Seria { get; set; }
        public int? ManufacturerId { get; set; }
        public Manufacturer? Manufacturer { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 4)]
        public string Photos { get; set; } = null!;
        [Range(2000, 2030)]
        public int? Year { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Color { get; set; } = null!;
        public string? Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public List<Review> Reviews { get; set; } = new();
    }
}
