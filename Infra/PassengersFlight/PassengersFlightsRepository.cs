using Airport.Data.PassengersFlight;
using Airport.Domain.PassengersFlight;

namespace Airport.Infra.PassengersFlight
{
    public sealed class PassengersFlightsRepository : UniqueEntityRepository<Domain.PassengersFlight.PassengersFlight, PassengersFlightData>, IPassengersFlightsRepository
    {
        public PassengersFlightsRepository(AirportDbContext c) : base(c, c.PassengersFlights) { }
        protected internal override Domain.PassengersFlight.PassengersFlight ToDomainObject(PassengersFlightData d) => new Domain.PassengersFlight.PassengersFlight(d);
    }
}
