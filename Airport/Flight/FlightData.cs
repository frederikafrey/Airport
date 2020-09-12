using Data.Common;

namespace Data.Flight
{
    public abstract class FlightData:UniqueEntityData
    {
        public string StartingPointId { get; set; }
        public string FinalPointId { get; set; }
        public int StartTime { get; set; }
        public int ArrivingTime { get; set; }
        public int Occupancy { get; set; }
        public string Company { get; set; }
        public string PlaneId { get; set; }

    }
}
