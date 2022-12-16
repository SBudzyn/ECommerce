using ECommerce.Models;
using ECommerce.Models.Domain;
using ECommerce.Models.Filters;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services.FilterServices
{
    public class FridgesFilterService : IFilter<FridgeFilters, Fridge>
    {
        public FridgesFilterService()
        {
            
        }
        public IEnumerable<Fridge?> Filter(FridgeFilters filters, IQueryable<Fridge> fridges)
        {
            if (filters.Manufacturer != null)
            {
                fridges = fridges.Where(p => p.Manufacturer != null).Where(p => p.Manufacturer!.Name.ToLower() == filters.Manufacturer.ToLower());
            }
            if (filters.MinPrice != null)
            {
                fridges = fridges.Where(p => p.Price >= filters.MinPrice);
            }
            if (filters.MaxPrice != null)
            {
                fridges = fridges.Where(p => p.Price <= filters.MaxPrice);
            }
            if (filters.Year != null)
            {
                fridges = fridges.Where(p => filters.Year.Any(y => y == p.Year));
            }
            if (filters.Color != null)
            {
                fridges = fridges.Where(p => filters.Color.Any(y => y.ToLower() == p.Color.ToLower()));
            }
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

            return fridges.ToList();
        }
    }
}
