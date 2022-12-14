using ECommerce.Models;
using ECommerce.Models.Domain;
using ECommerce.Models.Filters;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services.FilterServices
{
    public class TabletsFilterService : IFilter<TabletFilters, Tablet>
    {
        private IFilter<ProductFilters, Product> _productFilter;
        public TabletsFilterService(IFilter<ProductFilters, Product> productFilters)
        {
            _productFilter = productFilters;
        }

        public IEnumerable<Tablet?> Filter(TabletFilters filters, IQueryable<Tablet> tablets)
        {
            _productFilter.Filter(filters, tablets);
            if (filters.MinDisplaySize != null)
            {
                tablets = tablets.Where(t => t.DisplaySize >= filters.MinDisplaySize);
            }
            if (filters.MaxDisplaySize != null)
            {
                tablets = tablets.Where(t => t.DisplaySize <= filters.MaxDisplaySize);
            }
            if (filters.MinMemory != null)
            {
                tablets = tablets.Where(t => t.Memory >= filters.MinMemory);
            }
            if (filters.MaxMemory != null)
            {
                tablets = tablets.Where(t => t.Memory <= filters.MaxMemory);
            }
            return tablets;
        }
    }
}
