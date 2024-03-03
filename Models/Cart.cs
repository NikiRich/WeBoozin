using System.ComponentModel.DataAnnotations;
namespace WeBoozin.Models
{
    public class Cart
    {
        [Key]
        public int CartItemId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
