using Airport.Data.Luggage;
using Airport.Domain.Common;

namespace Airport.Domain.Luggage
{
    public sealed class Luggage : Entity<LuggageData>
    {
        public Luggage() : this(null) { }
        public Luggage(LuggageData data) : base(data) { }
    }
}
