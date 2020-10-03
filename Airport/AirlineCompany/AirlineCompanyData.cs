using Airport.Data.Common;

namespace Airport.Data.AirlineCompany
{
    public sealed class AirlineCompanyData : UniqueEntityData
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
