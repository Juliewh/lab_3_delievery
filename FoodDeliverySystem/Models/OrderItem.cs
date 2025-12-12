namespace FoodDelivery.Models
{
    public class OrderItem
    {
        public MenuItem Item { get; }
        public int Quantity { get; }
        public string Note { get; }

        public OrderItem(MenuItem item, int quantity = 1, string note = null)
        {
            Item = item;
            Quantity = quantity;
            Note = note;
        }

        public decimal GetTotal() => Item.Price * Quantity;
    }
}
