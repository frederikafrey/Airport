using Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.AirportFlight
{
    public abstract class AirportsFlightData:UniqueEntityData
    {
        public string FlightId { get; set; }
        public string AirportId { get; set; }
    }
}
