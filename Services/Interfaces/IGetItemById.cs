using ECommerce.Data;
using ECommerce.Models;

namespace ECommerce.Services.Interfaces
{
    public interface IGetItemById<T> where T : ProductFullResponse
    {
        T? GetById(int id);
    }
}
