namespace ECommerce.Models.Filters
{
    public class TabletFilters : ProductFilters 
    {
        public double? MinDisplaySize { get; set; }
        public double? MaxDisplaySize { get; set; }
        public int? MinMemory { get; set; }
        public int? MaxMemory { get; set; }
    }
}
