namespace ECommerce.Models.Filters
{
    public class LaptopFilters : ProductFilters 
    { 
        public double? MinDisplaySize { get; set; }
        public double? MaxDisplaySize { get; set; }      
        public int? MinRAM { get; set; }
        public int? MaxRAM { get; set; }
        public int? MinROM { get; set; }
        public int? MaxROM { get; set; }
        public string[]? Processor { get; set; }
        public string[]? OperatingSystem { get; set; } 
    }
}
