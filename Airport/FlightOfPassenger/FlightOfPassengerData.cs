﻿using Airport.Data.Common;

namespace Airport.Data.FlightOfPassenger
{
    public sealed class FlightOfPassengerData : UniqueEntityData
    {
        public string PassengerId { get; set; }
        public string LuggageId { get; set; }
        public int QuoteId { get; set; }

        //public string StartDestination { get; set; }
        //public string FinalDestination { get; set; }
    }
}
