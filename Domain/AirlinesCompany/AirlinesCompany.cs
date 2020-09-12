using Data.AirlinesCompany;
using Domain.Common;


namespace Domain.AirlinesCompany
{
    public sealed class AirlinesCompany : Entity<AirlinesCompanyData>
    {
        public AirlinesCompany() : this(null) { }
        public AirlinesCompany(AirlinesCompanyData data) : base(data) { }
    }
}
