using System.ComponentModel.DataAnnotations;

namespace AirAccess.Models
{
    public class Airline
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Airline Name is required")]
        [StringLength(100, ErrorMessage = "Airline Name cannot exceed 100 characters")]
        public string AirlineName { get; set; }
        public string AirlineCode { get; set; }

        public ICollection<Flight> Flights { get; set; } = new List<Flight>(); // Initialize collection
    }
}