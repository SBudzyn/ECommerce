using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public abstract class ProductFilters
    {
        [FromRoute]
        public string? Manufacturer { get; set; } 
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; } 
        public string[]? Color { get; set; }
        public int[]? Year { get; set; }
    }
}
