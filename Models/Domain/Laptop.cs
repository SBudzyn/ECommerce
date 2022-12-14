using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Laptop : Product
    {
        public Laptop(string name, double displaySize, int RAM, int ROM, string color, decimal price, string photos, string operatingSystem, string processor, Manufacturer? manufacturer = null, Seria? model = null, int? year = null, string? description = null)
            : base(name, color, price, photos, manufacturer, year, description)
        {
            this.DisplaySize = displaySize;
            this.OperatingSystem = operatingSystem;
            this.Processor = processor;
            this.RAM = RAM;
            this.ROM = ROM;
        }
        public Laptop()
        {

        }
        [Required]
        [Range(11, 15)]
        public double DisplaySize { get; set; }
        [Required]
        [Range(4000, 16000)]
        public int RAM { get; set; }
        [Required]
        [Range(256000, 1000000)]
        public int ROM { get; set; }
        [Required]
        [Range(1800, 6500)]
        public string Processor { get; set; } = null!;
        public string OperatingSystem { get; set; } = null!;

    }
}
