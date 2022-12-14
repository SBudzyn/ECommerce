using ECommerce.Models;
using ECommerce.Models.Domain;
using ECommerce.Models.Filters;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services.FilterServices
{
    public class HeadphonesFilterService : IFilter<HeadphonesFilters, Headphones>
    {
        private IFilter<ProductFilters, Product> _productFilter;
        public HeadphonesFilterService(IFilter<ProductFilters, Product> productFilters)
        {
            _productFilter = productFilters;
        }

        public IEnumerable<Headphones?> Filter(HeadphonesFilters filters, IQueryable<Headphones> headphones)
        {
            _productFilter.Filter(filters, headphones);
            if (filters.ConnectionType != null)
            {
                headphones.Where(h => h.ConnectionType == filters.ConnectionType);
            }
            if (filters.IsWaterProof != null)
            {
                headphones.Where(h => h.IsWaterProof == filters.IsWaterProof);
            }
            return headphones;
        }
    }
}
