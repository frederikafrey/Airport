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

        [Required]
        [DisplayName("Flight")]
        public string FlightId { get; set; }

        [DisplayName("Luggage")]
        public string LuggageId { get; set; }

        public string GetId() => $"{PassengerId}.{FlightId}";
    }
}
