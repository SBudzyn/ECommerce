using ECommerce.Models;

namespace ECommerce.Services.Interfaces
{
    public interface IFilter<T, U> where T : ProductFilters where U : Product
    {
        IEnumerable<U?> Filter(T filters, IQueryable<U> items);
    }
}
