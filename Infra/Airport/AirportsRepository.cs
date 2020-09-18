using Airport.Data.Airport;
using Airport.Domain.Airport;

namespace Airport.Infra.Airport
{
    public sealed class AirportsRepository : UniqueEntityRepository<Domain.Airport.Airport, AirportData>, IAirportsRepository
    {
        public AirportsRepository(AirportDbContext c) : base(c, c.Airports) { }
        protected internal override Domain.Airport.Airport ToDomainObject(AirportData d) => new Domain.Airport.Airport(d);
    }
}
