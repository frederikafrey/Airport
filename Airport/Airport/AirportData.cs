using Data.Common;

namespace Data.Airport
{
    public abstract class AirportData:UniqueEntityData
    {
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
