using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Airport.Facade.Common;

namespace Airport.Facade.FlightOfPassenger
{
    public sealed class FlightOfPassengerView : UniqueEntityView
    {
        [Required]
        [DisplayName("Passenger")]
        public string PassengerId { get; set; }
        public string PassengerOfFlightId { get; set; }
        public string StartDestinationId { get; set; }
        public string FinalDestinationId { get; set; }
        public string GetId() => $"{PassengerId}.{PassengerOfFlightId}";
    }
}
