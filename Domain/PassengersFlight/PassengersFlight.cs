using Airport.Domain.Common;
using Airport.Data.PassengersFlight;

namespace Airport.Domain.PassengersFlight
{
    public sealed class PassengersFlight : Entity<PassengersFlightData>
    {
        public PassengersFlight() : this(null) { }
        public PassengersFlight(PassengersFlightData data) : base(data) { }
    }
}
