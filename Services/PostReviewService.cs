using ECommerce.Data;
using ECommerce.Models;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services
{
    public class PostReviewService : IPostReview
    {
        private ECommerceContext _context;
        public PostReviewService(ECommerceContext context)
        {
            _context = context;
        }
        public bool PostReview(Review review)
        {
            if (_context.Phones.FirstOrDefault(p => p.Id == review.PhoneId) == null)
            {
                return false;
            }
            try
            {
                _context.Reviews.Add(review);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
