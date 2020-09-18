using Airport.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.PassengersFlight
{
    public sealed class PassengerFlightView : UniqueEntityView
    {
        [Required]
        [DisplayName("Passenger")]
        public string PassengerId { get; set; }
        public string FlightsPassengerId { get; set; }
        public string StartDestinationId { get; set; }
        public string FinalDestinationId { get; set; }
        public string GetId() => $"{PassengerId}.{FlightsPassengerId}";
    }
}
