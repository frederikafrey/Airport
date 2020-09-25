using Airport.Data.Common;

namespace Airport.Data.AirportOfFlight
{
    public sealed class AirportOfFlightData : UniqueEntityData
    {
        public string FlightId { get; set; }
        public string AirportId { get; set; }
    }
}
