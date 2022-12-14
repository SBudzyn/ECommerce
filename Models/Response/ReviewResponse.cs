namespace ECommerce.Models
{
    public class ReviewResponse
    {
        public ReviewResponse(string name, int mark, string? description)
        {
            Name = name;
            Mark = mark;
            Description = description;
        }
        public string Name { get; set; } = null!;
        public int Mark { get; set; }
        public string? Description { get; set; }
    }
}
