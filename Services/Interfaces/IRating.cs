using ECommerce.Models;

namespace ECommerce.Services.Interfaces
{
    public interface IRating
    {
        double? GetAverageRating(List<Review> reviews);
    }
}
