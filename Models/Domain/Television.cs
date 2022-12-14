using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.Domain
{
    public class Television : Product
    {
        public Television(string name, double displaySize, string resolution, string color, decimal price, string photos, Manufacturer? manufacturer = null, int? year = null, string? description = null)
            : base(name, color, price, photos, manufacturer, year, description)
        {
            DisplaySize = displaySize;
            Resolution = resolution;

        }
        public Television()
        {

        }
        [Required]
        [Range(30, 100)]
        public double DisplaySize { get; set; }
        [Required]
        public string? Resolution { get; set; }
    }
}
