using ECommerce.Models.Domain;

namespace ECommerce.Models.Filters
{
    public class HeadphonesFilters : ProductFilters
    {
        public ConnectionType? ConnectionType { get; set; }
        public bool? IsWaterProof { get; set; }
    }
}
