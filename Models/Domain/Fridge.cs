using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.Domain
{
    public class Fridge : Product
    {
        public Fridge(string name, string color, decimal price, string photos, int height, int width, int depth, int volume, Manufacturer? manufacturer = null, int? year = null, string? description = null)
            : base(name, color, price, photos, manufacturer, year, description)
        {
            Height = height;
            Width = width;
            Depth = depth;
            Volume = volume;
        }
        public Fridge()
        {

        }
        [Required]
        [Range(50, 210)]
        public int Height { get; set; }
        [Required]
        [Range(50, 110)]
        public int Width { get; set; }
        [Required]
        [Range(30, 80)]
        public int Depth { get; set; }
        [Range(90, 700)]
        public int Volume { get; set; }
    }
}
