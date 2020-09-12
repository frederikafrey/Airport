using Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Flight
{
    public abstract class FlightData:UniqueEntityData
    {
        public string StartingPoint { get; set; }
        public string FinalPoint { get; set; }
        public int StartTime { get; set; }
        public int ArrivingTime { get; set; }
        public int Occupancy { get; set; }
        public string Company { get; set; }
        public string PlaneId { get; set; }

    }
}
