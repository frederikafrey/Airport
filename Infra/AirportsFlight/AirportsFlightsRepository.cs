using Airport.Data.AirportsFlight;
using Airport.Domain.AirportsFlight;

namespace Airport.Infra.AirportsFlight
{
    public sealed class AirportsFlightsRepository : UniqueEntityRepository<Domain.AirportsFlight.AirportsFlight, AirportsFlightData>, IAirportsFlightsRepository
    {
        public AirportsFlightsRepository(AirportDbContext c) : base(c, c.AirportsFlights) { }
        protected internal override Domain.AirportsFlight.AirportsFlight ToDomainObject(AirportsFlightData d) => new Domain.AirportsFlight.AirportsFlight(d);
    }
}
