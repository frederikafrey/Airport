using Airport.Facade.Common;

namespace Airport.Facade.Flight
{
    public class FlightsView : UniqueEntityView
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
