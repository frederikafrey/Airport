using Airport.Data.AirportOfFlight;
using Airport.Domain.AirportOfFlight;

namespace Airport.Infra.AirportOfFlight
{
    public sealed class AirportOfFlightsRepository : UniqueEntityRepository<Domain.AirportOfFlight.AirportOfFlight, AirportOfFlightData>, IAirportOfFlightsRepository
    {
        public AirportOfFlightsRepository(AirportDbContext c) : base(c, c.AirportOfFlights) { }
        protected internal override Domain.AirportOfFlight.AirportOfFlight ToDomainObject(AirportOfFlightData d) => new Domain.AirportOfFlight.AirportOfFlight(d);
    }
}
