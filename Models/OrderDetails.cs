using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeBoozin.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Orders { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
