using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.Response
{
    public class LaptopFullResponse : ProductFullResponse
    {
        public LaptopFullResponse()
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
