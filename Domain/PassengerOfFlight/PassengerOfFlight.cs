using Airport.Data.PassengerOfFlight;
using Airport.Domain.Common;

namespace Airport.Domain.PassengerOfFlight
{
    public sealed class PassengerOfFlight : Entity<PassengerOfFlightData>
    {
        public PassengerOfFlight() : this(null) { }
        public PassengerOfFlight(PassengerOfFlightData ofFlightData) : base(ofFlightData) { }
    }
}
