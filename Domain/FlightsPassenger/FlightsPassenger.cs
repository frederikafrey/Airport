using Data.FlightsPassenger;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using Data.FlightsPassenger;

namespace Domain.FlightsPassanger
{
    public sealed class FlightsPassenger : Entity<FlightsPassengerData>
    {
        public FlightsPassenger() : this(null) { }
        public FlightsPassenger(FlightsPassengerData data) : base(data) { }
    }
}
