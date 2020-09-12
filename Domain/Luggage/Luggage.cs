using Data.Luggage;
using Domain.Common;

namespace Domain.Luggage
{
    public sealed class Luggage : Entity<LuggageData>
    {
        public Luggage() : this(null) { }
        public Luggage(LuggageData data) : base(data) { }
    }
}
