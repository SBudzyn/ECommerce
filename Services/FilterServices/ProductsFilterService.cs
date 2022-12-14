using ECommerce.Models;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services
{
    public class ProductsFilterService : IFilter<ProductFilters, Product>
    {
        public ProductsFilterService()
        {

        }
        public IEnumerable<Product?> Filter(ProductFilters filters, IQueryable<Product> items)
        {
            if (filters.Manufacturer != null)
            {
                items = items.Where(p => p.Manufacturer != null).Where(p => p.Manufacturer!.Name.ToLower() == filters.Manufacturer.ToLower());
            }
            if (filters.MinPrice != null)
            {
                items = items.Where(p => p.Price >= filters.MinPrice);
            }
            if (filters.MaxPrice != null)
            {
                items = items.Where(p => p.Price <= filters.MaxPrice);
            }
            if (filters.Year != null)
            {
                items = items.Where(p => filters.Year.Any(y => y == p.Year));
            }
            if (filters.Color != null)
            {
                items = items.Where(p => filters.Color.Any(y => y.ToLower() == p.Color.ToLower()));
            }
            return items;
        }
    }
}
