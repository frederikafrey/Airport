using Airport.Data.Common;

namespace Airport.Data.AirportsFlight
{
    public abstract class AirportsFlightData : UniqueEntityData
    {
        public string FlightId { get; set; }
        public string AirportId { get; set; }
    }
}
