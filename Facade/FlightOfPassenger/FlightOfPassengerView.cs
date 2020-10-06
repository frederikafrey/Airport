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

        [DisplayName("Start Destination")]
        public string StartDestination { get; set; }

        [DisplayName("Final Destination")]
        public string FinalDestination { get; set; }

        //public string GetId() => $"{FinalDestination}{PassengerId}";
    }
}
