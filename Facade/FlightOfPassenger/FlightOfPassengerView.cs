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
        [DisplayName("Passenger of Flight")]
        public string PassengerOfFlightId { get; set; }
        [DisplayName("Start Destination")]
        public string StartDestinationId { get; set; }
        [DisplayName("Final Destination")]
        public string FinalDestinationId { get; set; }
        public string GetId() => $"{PassengerId}.{PassengerOfFlightId}";
    }
}
