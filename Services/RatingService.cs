using ECommerce.Models;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services
{
    public class RatingService : IRating
    {
        public double? GetAverageRating(List<Review> reviews)
        {
            double sumOfRatings = 0;
            foreach (Review review in reviews)
            {
                sumOfRatings += review.Mark;
            }
            double avgRating = sumOfRatings / (reviews.Count() > 0 ? reviews.Count() : 1);
            return (avgRating != 0 ? avgRating : null);
        }
    }
}
