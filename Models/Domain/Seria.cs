using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Seria
    {
        public Seria()
        {

        }
        public Seria(string name, Manufacturer? manufacturer = null)
        {
            Name = name;
            Manufacturer = manufacturer;
        }
        public int Id { get; private set; }
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; } = null!;
        public int? ManufacturerId { get; set; }
        public Manufacturer? Manufacturer { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
