using System.ComponentModel.DataAnnotations;
namespace WeBoozin.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int QuantityInMl { get; set; }
        public int QuantityInStock { get; set; }
        public int CategoryId { get; set; }
    }
}
