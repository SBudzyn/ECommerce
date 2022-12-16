namespace ECommerce.Models.Domain
{
    public class CartItem : ICloneable
    {
        public CartItem(int id, string productName, string photo, decimal price, int quantity)
        {
            Id = id;
            ProductName = productName;
            Photo = photo;
            Price = price;
            Quantity = quantity;
        }
        public int Id { get; private set; }
        public string ProductName { get; private set; }
        public string Photo { get; private set; }
        private decimal _price;
        public decimal Price
        {
            get 
            { 
                return _price; 
            }
            private set 
            {
                if (value < 0)
                {
                    value = 0;
                }
                _price = value;
            }
        }
        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set 
            {
                if (value < 1)
                {
                    value = 1;
                }
                _quantity = value;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
