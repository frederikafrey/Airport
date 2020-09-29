using Airport.Data.StopOver;
using Airport.Domain.Common;

namespace Airport.Domain.StopOver
{
    public sealed class StopOver : Entity<StopOverData>
    {
        public StopOver() : this(null) { }
        public StopOver(StopOverData ofFlightData) : base(ofFlightData) { }
    }
}
