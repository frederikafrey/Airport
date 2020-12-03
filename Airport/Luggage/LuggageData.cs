using Airport.Data.Common;
using System.Collections.Generic;

namespace Airport.Data.Luggage
{
    public sealed class LuggageData : UniqueEntityData
    {
        public string PassengerId { get; set; }
        public string Name { get; set; }
        public string Dimensions { get; set; }
        public string Weight { get; set; }
    }
}
