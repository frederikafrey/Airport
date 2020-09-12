using Data.AirlinesCompany;
using Domain.Common;


namespace Domain.AirlineCompany
{
    public sealed class AirlinesCompany : Entity<AirlinesCompanyData>
    {
        public AirlinesCompany() : this(null) { }
        public AirlinesCompany(AirlinesCompanyData data) : base(data) { }
    }
}
