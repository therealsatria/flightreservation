using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirAccess.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Ticket Number is required")]
        public string TicketNumber { get; set; }

        [Required]
        public Guid BookingId { get; set; }
        [ForeignKey("BookingId")]
        public Booking Booking { get; set; }

        [Required]
        public Guid FlightId { get; set; }
        [ForeignKey("FlightId")]
        public Flight Flight { get; set; }
    }
}