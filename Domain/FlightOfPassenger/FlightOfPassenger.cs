using Airport.Data.FlightOfPassenger;
using Airport.Domain.Common;

namespace Airport.Domain.FlightOfPassenger
{
    public sealed class FlightOfPassenger : Entity<FlightOfPassengerData>
    {
        public FlightOfPassenger() : this(null) { }
        public FlightOfPassenger(FlightOfPassengerData ofPassengerData) : base(ofPassengerData) { }
    }
}
