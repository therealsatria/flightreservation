using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirAccess.Models
{
    public class FlightRoute
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid OriginAirportId { get; set; }
        [ForeignKey("OriginAirportId")]
        public Airport OriginAirport { get; set; }

        [Required]
        public Guid DestinationAirportId { get; set; }
        [ForeignKey("DestinationAirportId")]
        public Airport DestinationAirport { get; set; }

        public ICollection<Flight> Flights { get; set; } = new List<Flight>(); // Initialize collection
    }
}