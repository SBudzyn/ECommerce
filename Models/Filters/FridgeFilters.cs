namespace ECommerce.Models.Filters
{
    public class FridgeFilters : ProductFilters
    {
        public int? MinHeight { get; set; }
        public int? MaxHeight { get; set; }
        public int? MinWidth { get; set; }
        public int? MaxWidth { get; set; }
        public int? MinDepth { get; set; }
        public int? MaxDepth { get; set; }
        public int? MinVolume { get; set; }
        public int? MaxVolume { get; set; }
    }
}
