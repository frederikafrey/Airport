﻿using Airport.Data.Flight;
using Airport.Domain.Common;

namespace Airport.Domain.Flight
{
    public sealed class Flight : Entity<FlightData>
    {
        public Flight() : this(null) { }
        public Flight(FlightData data) : base(data) { }
    }
}
