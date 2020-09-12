using Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.FlightPassenger
{
    public abstract class FlightsPassengerData: UniqueEntityData
    {
        public string FlightId { get; set; }
        public string PassengersFlightId { get; set; }
    }
}
