using ECommerce.Models;
using ECommerce.Models.Filters;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services.FilterServices
{
    public class LaptopsFilterService : IFilter<LaptopFilters, Laptop>
    {
        public LaptopsFilterService()
        {
         
        }

        public IEnumerable<Laptop?> Filter(LaptopFilters filters, IQueryable<Laptop> laptops)
        {
            if (filters.Manufacturer != null)
            {
                laptops = laptops.Where(p => p.Manufacturer != null).Where(p => p.Manufacturer!.Name.ToLower() == filters.Manufacturer.ToLower());
            }
            if (filters.MinPrice != null)
            {
                laptops = laptops.Where(p => p.Price >= filters.MinPrice);
            }
            if (filters.MaxPrice != null)
            {
                laptops = laptops.Where(p => p.Price <= filters.MaxPrice);
            }
            if (filters.Year != null)
            {
                laptops = laptops.Where(p => filters.Year.Any(y => y == p.Year));
            }
            if (filters.Color != null)
            {
                laptops = laptops.Where(p => filters.Color.Any(y => y.ToLower() == p.Color.ToLower()));
            }
            if (filters.MinDisplaySize != null)
            {
                laptops = laptops.Where(l => l.DisplaySize >= filters.MinDisplaySize);
            }
            if (filters.MaxDisplaySize != null)
            {
                laptops = laptops.Where(l => l.DisplaySize <= filters.MaxDisplaySize);
            }
            if (filters.MinRAM != null)
            {
                laptops = laptops.Where(l => l.RAM >= filters.MinRAM);
            }
            if (filters.MaxRAM != null)
            {
                laptops = laptops.Where(l => l.RAM <= filters.MaxRAM);
            }
            if (filters.MinROM != null)
            {
                laptops = laptops.Where(l => l.ROM >= filters.MinROM);
            }
            if (filters.MaxROM != null)
            {
                laptops = laptops.Where(l => l.ROM <= filters.MaxROM);
            }
            if (filters.Processor != null)
            {
                laptops = laptops.Where(l => filters.Processor.Any(p=> p.ToLower() == l.Processor.ToLower()));
            }
            if (filters.OperatingSystem != null)
            {
                laptops = laptops.Where(l => filters.OperatingSystem.Any(p => p.ToLower() == l.OperatingSystem.ToLower()));
            }
            return laptops.ToList();
        }
    }
}
