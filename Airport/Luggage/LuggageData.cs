using Airport.Data.Common;

namespace Airport.Data.Luggage
{
    public sealed class LuggageData : UniqueEntityData
    {
        public string Dimensions { get; set; }
        public string Weight { get; set; }
    }
}
