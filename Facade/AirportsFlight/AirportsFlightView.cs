using Airport.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.AirportsFlight
{
    public sealed class AirportsFlightView : UniqueEntityView
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
