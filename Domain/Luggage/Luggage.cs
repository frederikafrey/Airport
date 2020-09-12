using Data.Luggage;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Luggage
{
    public sealed class Luggage : Entity<LuggageData>
    {
        public Luggage() : this(null) { }
        public Luggage(LuggageData data) : base(data) { }
    }
}
