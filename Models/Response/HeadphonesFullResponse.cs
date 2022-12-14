using ECommerce.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.Response
{
    public class HeadphonesFullResponse : ProductFullResponse
    {
        public HeadphonesFullResponse()
        {

        }
        [Required]
        public ConnectionType ConnectionType { get; set; }
        [Required]
        public bool IsWaterProof { get; set; }
    }
}
