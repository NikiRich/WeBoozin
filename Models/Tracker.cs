using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeBoozin.Models
{
    public class Tracker
    {
        [Key]
        public int TrackerId { get; set; }

        public string Username { get; set; } 

        public string ProductName { get; set; } 

        public int Quantity { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
