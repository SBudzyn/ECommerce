using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class PhoneFilters : ProductFilters
    {
        public PhoneFilters()
        {

        }
        public double? MinDisplaySize { get; set; }
        public double? MaxDisplaySize { get; set; }
        public int? MinMemory { get; set; }
        public int? MaxMemory { get; set; }
        public int? MinBatteryCapacity { get; set; }
        public int? MaxBatteryCapacity { get; set; }

    }
}
