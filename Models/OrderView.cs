namespace WeBoozin.Models
{
    public class OrderView
    {
        public int OrderId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
        public List<OrderItemView> OrderItems { get; set; } = new List<OrderItemView>();
    }
}
