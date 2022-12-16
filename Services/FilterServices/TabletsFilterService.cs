using ECommerce.Models;
using ECommerce.Models.Domain;
using ECommerce.Models.Filters;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services.FilterServices
{
    public class TabletsFilterService : IFilter<TabletFilters, Tablet>
    {
        public TabletsFilterService()
        {
   
        }

        public IEnumerable<Tablet?> Filter(TabletFilters filters, IQueryable<Tablet> tablets)
        {
            if (filters.Manufacturer != null)
            {
                tablets = tablets.Where(p => p.Manufacturer != null).Where(p => p.Manufacturer!.Name.ToLower() == filters.Manufacturer.ToLower());
            }
            if (filters.MinPrice != null)
            {
                tablets = tablets.Where(p => p.Price >= filters.MinPrice);
            }
            if (filters.MaxPrice != null)
            {
                tablets = tablets.Where(p => p.Price <= filters.MaxPrice);
            }
            if (filters.Year != null)
            {
                tablets = tablets.Where(p => filters.Year.Any(y => y == p.Year));
            }
            if (filters.Color != null)
            {
                tablets = tablets.Where(p => filters.Color.Any(y => y.ToLower() == p.Color.ToLower()));
            }
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
            return tablets.ToList();
        }
    }
}
