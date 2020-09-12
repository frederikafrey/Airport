using Airport.Data.Common;

namespace Airport.Data.AirlinesCompany
{
    public sealed class AirlinesCompanyData : UniqueEntityData
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
