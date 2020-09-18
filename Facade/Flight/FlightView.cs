using Airport.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.Flight
{
    public sealed class FlightView : UniqueEntityView
    {
        [Required]
        [DisplayName("Starting Point")]
        public string StartingPointId { get; set; }
        
        [Required]
        [DisplayName("Final Point")]
        public string FinalPointId { get; set; }
        
        [DataType(DataType.Time)]
        [Timestamp]
        public int StartTime { get; set; }
        
        [DataType(DataType.Time)]
        [Timestamp] 
        public int ArrivingTime { get; set; }
        
        [Required]
        [DisplayName("Occupancy")] 
        public int Occupancy { get; set; }
        public string Company { get; set; }
        
        [Required]
        [DisplayName("Plane nr.")]
        public string PlaneId { get; set; }
    }
}
