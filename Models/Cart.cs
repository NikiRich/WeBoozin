using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeBoozin.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
