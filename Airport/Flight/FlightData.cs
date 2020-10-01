using Airport.Data.Common;

namespace Airport.Data.Flight
{
    public sealed class FlightData : UniqueEntityData
    {
        public string StartingPointId { get; set; }
        public string FinalPointId { get; set; }
        public string StartTime { get; set; }
        public string ArrivingTime { get; set; }
        public int Occupancy { get; set; }
        public string Company { get; set; }
        public string PlaneId { get; set; }

    }
}
