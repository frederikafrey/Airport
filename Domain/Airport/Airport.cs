using Data.Airport;
using Airport.Domain.Common;

namespace Airport.Domain.Airport
{
    public sealed class Airport : Entity<AirportData>
    {
        public Airport() : this(null) { }
        public Airport(AirportData data) : base(data) { }
    }
}
