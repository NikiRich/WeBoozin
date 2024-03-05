using System.ComponentModel.DataAnnotations;
namespace WeBoozin.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string CategoryImage { get; set; }
    }
}
