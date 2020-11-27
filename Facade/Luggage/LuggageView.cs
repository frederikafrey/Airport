using Airport.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Airport.Facade.Luggage
{
    public sealed class LuggageView : UniqueEntityView
    {
        //[Required]
        //[DisplayName("Owner")]
        //public string FlightOfPassengerId { get; set; }
        public string Dimensions { get; set; }
        public int Weight { get; set; }
    }
}
