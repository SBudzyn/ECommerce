using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.Domain
{
    public class Tablet : Product
    {
        public Tablet(string name, double displaySize, int memory, string color, decimal price, string photos, Manufacturer? manufacturer = null, Seria? model = null, int? year = null, string? description = null)
            : base(name, color, price, photos, manufacturer, year, description)
        {
            this.DisplaySize = displaySize;
            this.Memory = memory;
            
        }
        public Tablet()
        {

        }
        [Required]
        [Range(7, 12)]
        public double DisplaySize { get; set; }
        [Required]
        [Range(16000, 512000)]
        public int Memory { get; set; }
         
    }
}
