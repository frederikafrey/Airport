using Airport.Data.AirportOfFlight;
using Airport.Domain.Common;

namespace Airport.Domain.AirportOfFlight
{
    public sealed class AirportOfFlight : Entity<AirportOfFlightData>
    {
        public AirportOfFlight() : this(null) { }
        public AirportOfFlight(AirportOfFlightData data) : base(data) { }
    }
}
