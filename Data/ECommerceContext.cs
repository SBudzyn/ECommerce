using Microsoft.EntityFrameworkCore;
using ECommerce.Models;
using ECommerce.Models.Domain;

namespace ECommerce.Data
{
    public class ECommerceContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; } = null!;
        public DbSet<Laptop> Laptops { get; set; } = null!;
        public DbSet<Tablet> Tablets { get; set; } = null!;
        public DbSet<Television> Televisions { get; set; } = null!;
        public DbSet<Fridge> Fridges { get; set; } = null!;
        public DbSet<Headphones> Headphones { get; set; } = null!;
        public DbSet<Seria> Serias { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
            
        }
        
       
    }
}
