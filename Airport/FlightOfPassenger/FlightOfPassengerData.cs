﻿using Airport.Data.Common;

namespace Airport.Data.FlightOfPassenger
{
    public sealed class FlightOfPassengerData : UniqueEntityData
    {
        public string PassengerId { get; set; }
        public string StartDestinationId { get; set; }
        public string FinalDestinationId { get; set; }
    }
}
