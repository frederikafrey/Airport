using Airport.Data.Common;

namespace Airport.Data.Flight
{
    public sealed class FlightData : UniqueEntityData
    {
        public string StartingPoint { get; set; }
        public string FinalPoint { get; set; }
        public string StartTime { get; set; }
        public string ArrivingTime { get; set; }
        public int Occupancy { get; set; }
        public string Company { get; set; }
        public string Plane { get; set; }
    }
}
