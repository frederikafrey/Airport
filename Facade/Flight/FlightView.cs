using Airport.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.Flight
{
    public sealed class FlightView : UniqueEntityView
    {
        [Required]
        [DisplayName("Start Country")]
        public string StartCountry { get; set; }

        [Required]
        [DisplayName("Starting City")]
        public string StartCity { get; set; }

        [Required]
        [DisplayName("Final Country")]
        public string FinalCountry { get; set; }

        [Required]
        [DisplayName("Final City")]
        public string FinalCity { get; set; }

        [DisplayName("Stop Over")]
        public string StopOver { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayName("Start Time")]
        public string StartTime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayName("Arrival Time")]
        public string ArrivalTime { get; set; }
        
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
