using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models.Domain
{
    public enum ConnectionType
    {
        Wireless,
        Wired
    }
    public class Headphones : Product
    {
        public Headphones(string name, string color, decimal price, string photos, ConnectionType connectionType, bool isWaterProof, Manufacturer? manufacturer = null, int? year = null, string? description = null)
            : base(name, color, price, photos, manufacturer, year, description)
        {
           ConnectionType = connectionType;
           IsWaterProof = isWaterProof;
        }
        public Headphones()
        {

        }
        [Required]
        public ConnectionType ConnectionType { get; set; }
        [Required]
        public bool IsWaterProof { get; set; }
    }
}
