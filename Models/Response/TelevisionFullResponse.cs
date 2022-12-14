using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.Response
{
    public class TelevisionFullResponse : ProductFullResponse
    {
        public TelevisionFullResponse()
        {

        }
        [Required]
        [Range(30, 100)]
        public double DisplaySize { get; set; }
        [Required]
        public string? Resolution { get; set; }
    }
}
