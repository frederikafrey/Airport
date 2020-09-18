using Airport.Data.AirlinesCompany;
using Airport.Domain.AirlinesCompany;

namespace Airport.Infra.AirlinesCompany
{
    public sealed class AirlinesCompaniesRepository : UniqueEntityRepository<Domain.AirlinesCompany.AirlinesCompany, AirlinesCompanyData>, IAirlinesCompaniesRepository
    {
        public AirlinesCompaniesRepository(AirportDbContext c) : base(c, c.AirlinesCompanies) { }
        protected internal override Domain.AirlinesCompany.AirlinesCompany ToDomainObject(AirlinesCompanyData d) => new Domain.AirlinesCompany.AirlinesCompany(d);
    }
}
