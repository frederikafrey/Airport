using Airport.Data.AirlinesCompany;
using Airport.Domain.Common;


namespace Airport.Domain.AirlinesCompany
{
    public sealed class AirlinesCompany : Entity<AirlinesCompanyData>
    {
        public AirlinesCompany() : this(null) { }
        public AirlinesCompany(AirlinesCompanyData data) : base(data) { }
    }
}
