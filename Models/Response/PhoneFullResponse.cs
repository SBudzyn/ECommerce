using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class PhoneFullResponse : ProductFullResponse
    {
        public PhoneFullResponse()
        {

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
    }
}
