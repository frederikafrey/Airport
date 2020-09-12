using Airport.Data.Common;

namespace Airport.Data.Airport
{
    public sealed class AirportData : UniqueEntityData
    {
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
