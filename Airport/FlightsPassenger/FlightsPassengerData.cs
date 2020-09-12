using Airport.Data.Common;

namespace Airport.Data.FlightsPassenger
{
    public sealed class FlightsPassengerData : UniqueEntityData
    {
        public string FlightId { get; set; }
        public string PassengersFlightId { get; set; }
    }
}
