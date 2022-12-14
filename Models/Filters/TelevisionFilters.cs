namespace ECommerce.Models.Filters
{
    public class TelevisionFilters : ProductFilters
    {
        public double? MinDisplaySize { get; set; }
        public double? MaxDisplaySize { get; set; }
        public string[]? Resolution { get; set; }
    }
}
