using Data.Common;

namespace Data.FlightsPassenger
{
    public abstract class FlightsPassengerData: UniqueEntityData
    {
        public string FlightId { get; set; }
        public string PassengersFlightId { get; set; }
    }
}
