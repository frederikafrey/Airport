using Airport.Data.Flight;
using Airport.Domain.Flight;

namespace Airport.Infra.Flight
{
    public sealed class FlightsRepository : UniqueEntityRepository<Domain.Flight.Flight, FlightData>, IFlightsRepository
    {
        public FlightsRepository(AirportDbContext c) : base(c, c.Flights) { }
        protected internal override Domain.Flight.Flight ToDomainObject(FlightData d) => new Domain.Flight.Flight(d);
    }
}
