using ECommerce.Models;
using ECommerce.Models.Domain;
using ECommerce.Models.Filters;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services.FilterServices
{
    public class HeadphonesFilterService : IFilter<HeadphonesFilters, Headphones>
    {
        public HeadphonesFilterService()
        {

        }

        public IEnumerable<Headphones?> Filter(HeadphonesFilters filters, IQueryable<Headphones> headphones)
        {
            if (filters.Manufacturer != null)
            {
                headphones = headphones.Where(p => p.Manufacturer != null).Where(p => p.Manufacturer!.Name.ToLower() == filters.Manufacturer.ToLower());
            }
            if (filters.MinPrice != null)
            {
                headphones = headphones.Where(p => p.Price >= filters.MinPrice);
            }
            if (filters.MaxPrice != null)
            {
                headphones = headphones.Where(p => p.Price <= filters.MaxPrice);
            }
            if (filters.Year != null)
            {
                headphones = headphones.Where(p => filters.Year.Any(y => y == p.Year));
            }
            if (filters.Color != null)
            {
                headphones = headphones.Where(p => filters.Color.Any(y => y.ToLower() == p.Color.ToLower()));
            }
            if (filters.ConnectionType != null)
            {
                headphones.Where(h => h.ConnectionType == filters.ConnectionType);
            }
            if (filters.IsWaterProof != null)
            {
                headphones.Where(h => h.IsWaterProof == filters.IsWaterProof);
            }
            return headphones.ToList();
        }
    }
}
