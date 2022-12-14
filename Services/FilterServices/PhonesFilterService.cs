using ECommerce.Data;
using ECommerce.Models;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services
{
    public class PhonesFilterService : IFilter<PhoneFilters, Phone>
    {
        private IFilter<ProductFilters, Product> _productFilter;
        public PhonesFilterService(IFilter<ProductFilters, Product> productFilters)
        {
            _productFilter = productFilters;
        }
        public IEnumerable<Phone?> Filter(PhoneFilters filters, IQueryable<Phone> phones)
        {
            _productFilter.Filter(filters, phones);          
            if (filters.MinMemory != null)
            {
                phones = phones.Where(p => p.Memory >= filters.MinMemory);
            }
            if (filters.MaxMemory != null)
            {
                phones = phones.Where(p => p.Memory <= filters.MaxMemory);
            }
            if (filters.MinBatteryCapacity != null)
            {
                phones = phones.Where(p => p.BatteryCapacity >= filters.MinBatteryCapacity);
            }
            if (filters.MaxBatteryCapacity != null)
            {
                phones = phones.Where(p => p.BatteryCapacity <= filters.MaxBatteryCapacity);
            }
            if (filters.MinDisplaySize != null)
            {
                phones = phones.Where(p => p.DisplaySize >= filters.MinDisplaySize);
            }
            if (filters.MaxDisplaySize != null)
            {
                phones = phones.Where(p => p.DisplaySize <= filters.MaxDisplaySize);
            }

            return phones;
        }
    }
}
