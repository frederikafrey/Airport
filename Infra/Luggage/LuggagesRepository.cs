using Airport.Data.Luggage;
using Airport.Domain.Luggage;

namespace Airport.Infra.Luggage
{
    public sealed class LuggagesRepository : UniqueEntityRepository<Domain.Luggage.Luggage, LuggageData>, ILuggagesRepository
    {
        public LuggagesRepository(AirportDbContext c) : base(c, c.Luggages) { }
        protected internal override Domain.Luggage.Luggage ToDomainObject(LuggageData d) => new Domain.Luggage.Luggage(d);
    }
}
