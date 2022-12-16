using ECommerce.Models;
using ECommerce.Models.Domain;
using ECommerce.Models.Filters;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services.FilterServices
{
    public class TelevisionsFilterService : IFilter<TelevisionFilters, Television>
    {
       
        public TelevisionsFilterService()
        {

        }

        public IEnumerable<Television?> Filter(TelevisionFilters filters, IQueryable<Television> televisions)
        {
            if (filters.Manufacturer != null)
            {
                televisions = televisions.Where(p => p.Manufacturer != null).Where(p => p.Manufacturer!.Name.ToLower() == filters.Manufacturer.ToLower());
            }
            if (filters.MinPrice != null)
            {
                televisions = televisions.Where(p => p.Price >= filters.MinPrice);
            }
            if (filters.MaxPrice != null)
            {
                televisions = televisions.Where(p => p.Price <= filters.MaxPrice);
            }
            if (filters.Year != null)
            {
                televisions = televisions.Where(p => filters.Year.Any(y => y == p.Year));
            }
            if (filters.Color != null)
            {
                televisions = televisions.Where(p => filters.Color.Any(y => y.ToLower() == p.Color.ToLower()));
            }
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
                televisions = televisions.Where(t => t.Resolution != null).Where(t => filters.Resolution.Any(r => r.ToLower() == t.Resolution!.ToLower()));
            }
            return televisions.ToList();
        }
    }
}
