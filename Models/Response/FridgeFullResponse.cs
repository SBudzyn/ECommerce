using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.Response
{
    public class FridgeFullResponse : ProductFullResponse
    {
        public FridgeFullResponse()
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
