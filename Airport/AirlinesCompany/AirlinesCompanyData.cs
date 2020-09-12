using Data.Common;

namespace Data.AirlinesCompany
{
    public abstract class AirlinesCompanyData:UniqueEntityData
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
