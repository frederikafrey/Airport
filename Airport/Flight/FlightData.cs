using Airport.Data.Common;

namespace Airport.Data.Flight
{
    public sealed class FlightData : UniqueEntityData
    {
        public string StartCountry { get; set; }
        public string FinalCountry { get; set; }
        public string StartCity { get; set; }
        public string FinalCity { get; set; }
        public string StopOver { get; set; }
        public string StartTime { get; set; }
        public string ArrivalTime { get; set; }
        public int Occupancy { get; set; }
        public string Company { get; set; }
        public string Plane { get; set; }
    }
}
