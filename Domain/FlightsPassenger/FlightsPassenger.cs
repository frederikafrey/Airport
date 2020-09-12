using Airport.Data.FlightsPassenger;
using Airport.Domain.Common;

namespace Airport.Domain.FlightsPassenger
{
    public sealed class FlightsPassenger : Entity<FlightsPassengerData>
    {
        public FlightsPassenger() : this(null) { }
        public FlightsPassenger(FlightsPassengerData data) : base(data) { }
    }
}
