using AutoMapper;
using ECommerce.Data;
using ECommerce.Models;
using ECommerce.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Services
{
    public class RetrieveProductsService<T, U, F> : IGetItemById<U>, IGetItems<F> where T : Product where U : ProductFullResponse where F : ProductFilters 
    {
        private ECommerceContext _context;
        private DbSet<T> dbSet;
        private IFilter<F, T> _filter;
        IMapper _mapper;
        IRating _ratingService;
        public RetrieveProductsService(ECommerceContext context, IFilter<F, T> filter, IMapper mapper, IRating ratingService)
        {
            _context = context;
            _context.Reviews.Load<Review>();
            _context.Phones.Load<Phone>();
            _context.Manufacturers.Load<Manufacturer>();
            _context.Serias.Load<Seria>();
            _filter = filter;
            dbSet = context.Set<T>();
            _mapper = mapper;
            _ratingService = ratingService;
        }
        public U? GetById(int id)
        {
            var item = dbSet.FirstOrDefault(i => i.Id == id);
            var mappedItem = _mapper.Map<U>(item);
            mappedItem.Rating = _ratingService.GetAverageRating(item!.Reviews);
            mappedItem.NumberOfReviews = item.Reviews.Count() == 0 ? null : item.Reviews.Count();
            return mappedItem;
        }

        public IEnumerable<ProductShortResponse> GetItems(F filters)
        {
            IQueryable<T> products = dbSet;     
            var filteredProducts = _filter.Filter(filters, products);
            List<ProductShortResponse> mappedProducts = new List<ProductShortResponse>();
            foreach (var product in filteredProducts)
            {
                var mapped = _mapper.Map<ProductShortResponse>(product);
                mapped.Rating = _ratingService.GetAverageRating(product!.Reviews);
                mapped.NumberOfReviews = product.Reviews.Count() == 0 ? null : product.Reviews.Count();
                mappedProducts.Add(mapped);

            }
            return mappedProducts;
        }

        
    }
}
