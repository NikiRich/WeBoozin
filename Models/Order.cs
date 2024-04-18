using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeBoozin.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public OrderStatus Status { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }


        public enum OrderStatus
        {
            Processing,
            Sent,
            Delivered
        }
    }
}
