namespace WeBoozin.Models
{
    public class Cart
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        
        public int CartItemId { get; set; }
    }
}
