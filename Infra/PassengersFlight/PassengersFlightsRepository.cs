using Airport.Data.Passenger;
using Airport.Domain.Passenger;

namespace Airport.Infra.PassengersFlight
{
    public class PassengersFlightsRepository
    {
    }
    public sealed class PassengersRepository : UniqueEntityRepository<Domain.Passenger.Passenger, PassengerData>, IPassengersRepository
    {
        public PassengersRepository(AirportDbContext c) : base(c, c.Passengers) { }
        protected internal override Domain.Passenger.Passenger ToDomainObject(PassengerData d) => new Domain.Passenger.Passenger(d);
    }
}
