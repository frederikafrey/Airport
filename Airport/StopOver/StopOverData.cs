using Airport.Data.Common;

namespace Airport.Data.StopOver
{
    public sealed class StopOverData : UniqueEntityData
    {
        public string FlightId { get; set; }
        public string FlightOfPassengerId { get; set; }
    }
}
