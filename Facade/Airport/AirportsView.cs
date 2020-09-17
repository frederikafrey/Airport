using Airport.Facade.Common;

namespace Airport.Facade.Airport
{
    public sealed class AirportsView : UniqueEntityView 
    {
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
