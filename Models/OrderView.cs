namespace WeBoozin.Models
{
    public class OrderView
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
        public List<OrderItemView> OrderItems { get; set; }
    }
}
