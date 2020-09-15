using Airport.Facade.Common;

namespace Airport.Facade.FlightsPassenger
{
    public class FlightsPassengersView : UniqueEntityView
    {
        public string FlightId { get; set; }
        public string PassengersFlightId { get; set; }
    }
}
