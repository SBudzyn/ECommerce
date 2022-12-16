using ECommerce.Data;
using ECommerce.Models;
using ECommerce.Services.Interfaces;

namespace ECommerce.Services
{
    public class PostReviewService : IPostReview
    {
        private ECommerceContext _context;
        private IValidate<Review> _validator;
        public PostReviewService(ECommerceContext context, IValidate<Review>validator)
        {
            _context = context;
            _validator = validator;
        }
        public bool PostReview(Review review)
        {
            if (_context.Phones.FirstOrDefault(p => p.Id == review.ProductId) == null)
            {
                return false;
            }

            if (_validator.Validate(review) == null)
            {
                return false;
            }

            try
            {
                _context.Reviews.Add(review);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
