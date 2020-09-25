using Airport.Data.PassengerOfFlight;
using Airport.Domain.PassengerOfFlight;

namespace Airport.Infra.PassengerOfFlight
{
    public sealed class PassengerOfFlightsRepository : UniqueEntityRepository<Domain.PassengerOfFlight.PassengerOfFlight, PassengerOfFlightData>, IPassengerOfFlightsRepository
    {
        public PassengerOfFlightsRepository(AirportDbContext c) : base(c, c.PassengerOfFlights) { }
        protected internal override Domain.PassengerOfFlight.PassengerOfFlight ToDomainObject(PassengerOfFlightData d) => new Domain.PassengerOfFlight.PassengerOfFlight(d);
    }
}
