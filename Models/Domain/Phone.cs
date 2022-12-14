using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
   
    public class Phone : Product
    {
        public Phone()
        {

        }
        public Phone(string name, double displaySize, int memory, int batteryCapacity, string color, decimal price, string photos, int mainCamera, int frontCamera, Manufacturer? manufacturer = null, Seria? model = null, int? year = null, string? description = null)
            : base(name, color, price, photos, manufacturer, year, description)
        {
            
            DisplaySize = displaySize;
            Memory = memory;
            BatteryCapacity = batteryCapacity;           
            Seria = model;
            MainCamera = mainCamera;
            FrontCamera = frontCamera;
            
        }
       
        
        
        [Required]
        [Range(2.2, 7)]
        public double DisplaySize { get; set; }
        [Required]
        [Range(16000, 512000)]
        public int Memory { get; set; }
        [Required]
        [Range(1800, 6500)]
        public int BatteryCapacity { get; set; }
        public int MainCamera { get; set; }
        public int? FrontCamera { get; set; }

    }
}
