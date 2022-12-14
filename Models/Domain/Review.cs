using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    
    public class Review
    {
        public Review()
        {

        }
        public Review(string name, string email, int mark, int productId, string? phoneNumber = null, string? description = null)
        {
            Name = name;
            Email = email;
            Mark = mark;
            PhoneNumber = phoneNumber;
            Description = description;
            ProductId = productId;
        }
        public int Id { get; private set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; } = null!;
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        [Required]
        [Range(1, 10)]
        public int Mark { get; set; }
        [StringLength(500, MinimumLength = 5)]
        public string? Description { get; set; }
        [Required]
        public int ProductId { get; set; }
    }
}
