using Airport.Data.FlightsPassenger;
using Airport.Domain.FlightsPassenger;

namespace Airport.Infra.FlightsPassenger
{
    public sealed class FlightsPassengersRepository : UniqueEntityRepository<Domain.FlightsPassenger.FlightsPassenger, FlightsPassengerData>, IFlightsPassengersRepository
    {
        public FlightsPassengersRepository(AirportDbContext c) : base(c, c.FlightsPassengers) { }
        protected internal override Domain.FlightsPassenger.FlightsPassenger ToDomainObject(FlightsPassengerData d) => new Domain.FlightsPassenger.FlightsPassenger(d);
    }
}
