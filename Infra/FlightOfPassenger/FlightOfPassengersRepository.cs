using Airport.Data.FlightOfPassenger;
using Airport.Domain.FlightOfPassenger;

namespace Airport.Infra.FlightOfPassenger
{
    public sealed class FlightOfPassengersRepository : UniqueEntityRepository<Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerData>, IFlightOfPassengersRepository
    {
        public FlightOfPassengersRepository(AirportDbContext c) : base(c, c.FlightOfPassengers) { }
        protected internal override Domain.FlightOfPassenger.FlightOfPassenger ToDomainObject(FlightOfPassengerData d) => new Domain.FlightOfPassenger.FlightOfPassenger(d);
    }
}
