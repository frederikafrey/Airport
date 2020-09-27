using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Airport.Facade.Common;

namespace Airport.Facade.PassengerOfFlight
{
    public sealed class PassengerOfFlightView : UniqueEntityView
    {
        [Required]
        [DisplayName("Flight")]
        public string FlightId { get; set; }
       
        [DisplayName("Flight of Passenger")]
        public string FlightOfPassengerId { get; set; }
        public string GetId() => $"{FlightId}.{FlightOfPassengerId}";
    }
}
