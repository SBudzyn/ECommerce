using ECommerce.Models;
using ECommerce.Models.Filters;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services.FilterServices
{
    public class LaptopsFilterService : IFilter<LaptopFilters, Laptop>
    {
        private IFilter<ProductFilters, Product> _productFilter;
        public LaptopsFilterService(IFilter<ProductFilters, Product> productFilters)
        {
            _productFilter = productFilters;
        }

        public IEnumerable<Laptop?> Filter(LaptopFilters filters, IQueryable<Laptop> laptops)
        {
            _productFilter.Filter(filters, laptops);
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
            return laptops;
        }
    }
}
