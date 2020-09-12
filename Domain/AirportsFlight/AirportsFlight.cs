using Airport.Data.AirportsFlight;
using Airport.Domain.Common;

namespace Airport.Domain.AirportsFlight
{
    public sealed class AirportsFlight : Entity<AirportsFlightData>
    {
        public AirportsFlight() : this(null) { }
        public AirportsFlight(AirportsFlightData data) : base(data) { }
    }
}
