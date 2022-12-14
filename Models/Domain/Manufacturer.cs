
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    
    public class Manufacturer
    {
        public Manufacturer()
        {
                
        }
        public Manufacturer(string name, string country, string? description = null)
        {
            Name = name;
            Country = country;
            Description = description;
        }
        public int Id { get; private set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Country { get; set; } = null!;
        public List<Product> Products { get; set; } = new();
        public string? Description { get; set; }
        public List<Seria> Serias { get; set; } = new();
    }
}
