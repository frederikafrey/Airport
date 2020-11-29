using Airport.Facade.Common;

namespace Airport.Facade.Airport
{
    public sealed class AirportView : UniqueEntityView 
    {
        public string Country { get; set; }
        public string Phone { get; set; }
    }
}
