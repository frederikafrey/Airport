using Airport.Domain.Common;
using Airport.Data.Passenger;

namespace Airport.Domain.Passenger
{
    public sealed class Passenger : Entity<PassengerData>
    {
        public Passenger() : this(null) { }
        public Passenger(PassengerData data) : base(data) { }
    }
}
