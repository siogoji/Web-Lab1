using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int TrainId { get; set; }
        public string? PassengerName { get; set; }
        public string? DepartureCity { get; set; }
        public string? ArrivalCity { get; set; }
        public float Price { get; set; }
        public int SeatNumber { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
    }
}
