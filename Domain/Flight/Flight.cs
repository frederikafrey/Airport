using Data.Flight;
using Domain.Common;

namespace Domain.Flight
{
    public sealed class Flight : Entity<FlightData>
    {
        public Flight() : this(null) { }
        public Flight(FlightData data) : base(data) { }
    }
}
