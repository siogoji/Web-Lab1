using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Train
    {
        public int TrainId { get; set; }
        public string? DepartureCity { get; set; }
        public string? ArrivalCity { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
    }
}
