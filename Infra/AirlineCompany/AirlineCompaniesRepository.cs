using Airport.Data.AirlineCompany;
using Airport.Domain.AirlineCompany;

namespace Airport.Infra.AirlineCompany
{
    public sealed class AirlineCompaniesRepository : UniqueEntityRepository<Domain.AirlineCompany.AirlineCompany, AirlineCompanyData>, IAirlineCompaniesRepository
    {
        public AirlineCompaniesRepository(AirportDbContext c) : base(c, c.AirlinesCompanies) { }
        protected internal override Domain.AirlineCompany.AirlineCompany ToDomainObject(AirlineCompanyData d) => new Domain.AirlineCompany.AirlineCompany(d);
    }
}
