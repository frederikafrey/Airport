using Airport.Data.StopOver;
using Airport.Domain.StopOver;

namespace Airport.Infra.StopOver
{
    public sealed class StopOversRepository : UniqueEntityRepository<Domain.StopOver.StopOver, StopOverData>, IStopOversRepository
    {
        public StopOversRepository(AirportDbContext c) : base(c, c.StopOvers) { }
        protected internal override Domain.StopOver.StopOver ToDomainObject(StopOverData d) => new Domain.StopOver.StopOver(d);
    }
}
