using ECommerce.Data;
using ECommerce.Models;

namespace ECommerce.Services.Interfaces
{
    public interface IGetItems<F> where F : ProductFilters
    {
        IEnumerable<ProductShortResponse> GetItems(F filters);
    }
}
