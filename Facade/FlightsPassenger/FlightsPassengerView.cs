using Airport.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.FlightsPassenger
{
    public sealed class FlightsPassengerView : UniqueEntityView
    {
        [Required]
        [DisplayName("Flight")]
        public string FlightId { get; set; }
        public string PassengersFlightId { get; set; }
        public string GetId() => $"{FlightId}.{PassengersFlightId}";
    }
}
