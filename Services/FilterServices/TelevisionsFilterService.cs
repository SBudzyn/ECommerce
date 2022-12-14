using ECommerce.Models;
using ECommerce.Models.Domain;
using ECommerce.Models.Filters;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services.FilterServices
{
    public class TelevisionsFilterService : IFilter<TelevisionFilters, Television>
    {
        private IFilter<ProductFilters, Product> _productFilter;
        public TelevisionsFilterService(IFilter<ProductFilters, Product> productFilters)
        {
            _productFilter = productFilters;
        }

        public IEnumerable<Television?> Filter(TelevisionFilters filters, IQueryable<Television> televisions)
        {
            _productFilter.Filter(filters, televisions);
            if (filters.MinDisplaySize != null)
            {
                televisions = televisions.Where(t => t.DisplaySize >= filters.MinDisplaySize);
            }
            if (filters.MaxDisplaySize != null)
            {
                televisions = televisions.Where(t => t.DisplaySize <= filters.MaxDisplaySize);
            }
            if (filters.Resolution != null)
            {
                televisions = televisions.Where(t => filters.Resolution.Any(r => r.ToLower() == t.Resolution.ToLower()));
            }
            return televisions;
        }
    }
}
