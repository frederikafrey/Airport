using Data.AirportFlight;
using Data.AirportśFlight;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AirportFlight
{
    public sealed class AirportsFlight : Entity<AirportsFlightData>
    {
        public AirportsFlight() : this(null) { }
        public AirportsFlight(AirportsFlightData data) : base(data) { }
    }
}
