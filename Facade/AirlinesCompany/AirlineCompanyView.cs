using Airport.Facade.Common;

namespace Airport.Facade.AirlinesCompany
{
    public sealed class AirlineCompanyView : UniqueEntityView 
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
