using System;
using Airport.Data.StopOver;
using Airport.Infra;
using Airport.Infra.StopOver;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.StopOver
{
    [TestClass]
    public class StopOversRepositoryTests : RepositoryTests<StopOversRepository, global::Airport.Domain.StopOver.StopOver, StopOverData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            DbSet = ((AirportDbContext)db).StopOvers;
            obj = new StopOversRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.StopOver.StopOver, StopOverData>);

        protected override string GetId(StopOverData d) => d.Id;

        protected override global::Airport.Domain.StopOver.StopOver GetObject(StopOverData d) => new global::Airport.Domain.StopOver.StopOver(d);

        protected override void SetId(StopOverData d, string id) => d.Id = id;
    }
}
