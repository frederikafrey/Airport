using Airport.Data.Common;

namespace Airport.Data.FlightOfPassenger
{
    public sealed class FlightOfPassengerData : UniqueEntityData
    {
        public string PassengerId { get; set; }
        public string LuggageId { get; set; }
        public string FlightId { get; set; }

        //public int QuoteId { get; set; }
    }
}
