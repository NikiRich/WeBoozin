using System.ComponentModel.DataAnnotations;
namespace WeBoozin.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
    }
}
