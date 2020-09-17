using Airport.Facade.Common;

namespace Airport.Facade.FlightsPassenger
{
    public sealed class FlightsPassengersView : UniqueEntityView
    {
        public string FlightId { get; set; }
        public string PassengersFlightId { get; set; }
        public string GetId() => $"{FlightId}.{PassengersFlightId}";
    }
}
