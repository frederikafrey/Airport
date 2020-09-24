using Airport.Data.Common;

namespace Airport.Data.Airport
{
    public sealed class AirportData : UniqueEntityData
    {
        public string Country { get; set; }
        public string Phone { get; set; }
    }
}
