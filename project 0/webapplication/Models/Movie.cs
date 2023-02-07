using System.ComponentModel.DataAnnotations;

namespace webapplication.Models
{
    public class Movie
    {
        [Key]
        public int Mid { get; set; }
        public string Mname { get; set; }
        public string Director { get; set; }
        public int TicketPrice { get; set; }
    }
}
