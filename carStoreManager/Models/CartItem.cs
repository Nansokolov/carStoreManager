namespace carStoreManager.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string? ItemName { get; set; }
        public string? Price { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; } // Store the user's ID
        public Car Car { get; set; }
    }
}
