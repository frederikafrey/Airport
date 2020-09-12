using Data.FlightPassenger;
using Airport.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Domain.FlightsPassenger
{
    public sealed class FlightsPassenger : Entity<FlightsPassengerData>
    {
        public FlightsPassenger() : this(null) { }
        public FlightsPassenger(FlightsPassengerData data) : base(data) { }
    }
}
