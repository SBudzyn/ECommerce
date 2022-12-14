using ECommerce.Models;
using ECommerce.Models.Domain;
using ECommerce.Models.Filters;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services.FilterServices
{
    public class FridgesFilterService : IFilter<FridgeFilters, Fridge>
    {
        private IFilter<ProductFilters, Product> _productFilter;
        public FridgesFilterService(IFilter<ProductFilters, Product> productFilters)
        {
            _productFilter = productFilters;
        }
        public IEnumerable<Fridge?> Filter(FridgeFilters filters, IQueryable<Fridge> fridges)
        {
            _productFilter.Filter(filters, fridges);
            if (filters.MinHeight != null)
            {
                fridges = fridges.Where(f => f.Height >= filters.MinHeight);
            }
            if (filters.MaxHeight != null)
            {
                fridges = fridges.Where(f => f.Height <= filters.MaxHeight);
            }
            if (filters.MinWidth != null)
            {
                fridges = fridges.Where(f => f.Width >= filters.MinWidth);
            }
            if (filters.MaxWidth != null)
            {
                fridges = fridges.Where(f => f.Width <= filters.MaxWidth);
            }
            if (filters.MinDepth != null)
            {
                fridges = fridges.Where(f => f.Depth >= filters.MinDepth);
            }
            if (filters.MaxDepth != null)
            {
                fridges = fridges.Where(f => f.Depth <= filters.MaxDepth);
            }
            if (filters.MinVolume != null)
            {
                fridges = fridges.Where(f => f.Volume >= filters.MinVolume);
            }
            if (filters.MaxVolume!= null)
            {
                fridges = fridges.Where(f => f.Volume <= filters.MaxVolume);
            }

            return fridges;
        }
    }
}
