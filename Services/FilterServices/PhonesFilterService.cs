using ECommerce.Data;
using ECommerce.Models;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services
{
    public class PhonesFilterService : IFilter<PhoneFilters, Phone>
    {

        public PhonesFilterService()
        {
       
        }
        public IEnumerable<Phone?> Filter(PhoneFilters filters, IQueryable<Phone> phones)
        {
            if (filters.Manufacturer != null)
            {
                phones = phones.Where(p => p.Manufacturer != null).Where(p => p.Manufacturer!.Name.ToLower() == filters.Manufacturer.ToLower());
            }
            if (filters.MinPrice != null)
            {
                phones = phones.Where(p => p.Price >= filters.MinPrice);
            }
            if (filters.MaxPrice != null)
            {
                phones = phones.Where(p => p.Price <= filters.MaxPrice);
            }
            if (filters.Year != null)
            {
                phones = phones.Where(p => filters.Year.Any(y => y == p.Year));
            }
            if (filters.Color != null)
            {
                phones = phones.Where(p => filters.Color.Any(y => y.ToLower() == p.Color.ToLower()));
            }
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

            return phones.ToList();
        }
    }
}
