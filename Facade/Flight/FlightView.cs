using Airport.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.Flight
{
    public sealed class FlightView : UniqueEntityView
    {
        [Required]
        [DisplayName("Starting Point")]
        public string StartingPoint { get; set; }

        [Required]
        [DisplayName("Starting City")]
        public string StartCity { get; set; }

        [Required]
        [DisplayName("Final Point")]
        public string FinalPoint { get; set; }

        [Required]
        [DisplayName("Final City")]
        public string FinalCity { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Start Time")]
        public string StartTime { get; set; }
        
        [DataType(DataType.DateTime)]
        [DisplayName("Arriving Time")]
        public string ArrivingTime { get; set; }
        
        [Required]
        [DisplayName("Occupancy")] 
        public int Occupancy { get; set; }

        [Required]
        [DisplayName("Company")]
        public string Company { get; set; }
        
        [Required]
        [DisplayName("Plane nr.")]
        public string Plane { get; set; }
    }
}
