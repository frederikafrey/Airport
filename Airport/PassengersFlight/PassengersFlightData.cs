using Data.Common;
using System;

namespace Airport
{
    public class PassengersFlightData:UniqueEntityData
    {
        public string PassengerId { get; set; }
        public string FlightsPassengerId { get; set; }
        public string StartDestination { get; set; }
        public string FinalDestination { get; set; }
    }
}
