using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.Response
{
    public class TabletFullResponse : ProductFullResponse
    {
        public TabletFullResponse()
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
