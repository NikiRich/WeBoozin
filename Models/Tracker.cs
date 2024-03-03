using System.ComponentModel.DataAnnotations;
namespace WeBoozin.Models
{
    public class Tracker
    {
        [Key]
        public int TrackerId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Date { get; set; }
    }
}
