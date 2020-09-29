using Airport.Data.Common;

namespace Airport.Data.Luggage
{
    public sealed class LuggageData : UniqueEntityData
    {
        public string FlightOfPassengerId { get; set; }
        public int Dimensions { get; set; }
        public int Weight { get; set; }
    }
}
