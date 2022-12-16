namespace ECommerce.Models.Domain
{
    [Serializable]
    public class Cart
    {
        public Cart()
        {

        }
        public Dictionary<int, CartItem> Items { get; } = new();
        public void AddItem(int id)
        {
            if (Items.ContainsKey(id))
            {
                Items[id].Quantity++;
            }
            else
            {
                //CHANGE
                
            }
        }
    }
}
