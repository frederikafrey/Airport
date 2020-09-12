using Airport;
using Domain.Common;


namespace Domain.PassengersFlight
{
    public sealed class PassengersFlight : Entity<PassengersFlightData>
    {
        public PassengersFlight() : this(null) { }
        public PassengersFlight(PassengersFlightData data) : base(data) { }
    }
}
