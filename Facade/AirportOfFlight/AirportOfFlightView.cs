using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Airport.Facade.Common;

namespace Airport.Facade.AirportOfFlight
{
    public sealed class AirportOfFlightView : UniqueEntityView
    {
        [Required]
        [DisplayName("Flight")]
        public string FlightId { get; set; }
        [Required]
        [DisplayName("Airport")]
        public string AirportId { get; set; }
        public string GetId() => $"{FlightId}.{AirportId}";
    }
}
