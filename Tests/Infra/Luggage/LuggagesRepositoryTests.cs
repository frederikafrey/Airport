using System;
using Airport.Data.Luggage;
using Airport.Infra;
using Airport.Infra.Luggage;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.Luggage
{
    [TestClass]
    public class LuggagesRepositoryTests : RepositoryTests<LuggagesRepository, global::Airport.Domain.Luggage.Luggage, LuggageData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            dbSet = ((AirportDbContext)db).Luggages;
            obj = new LuggagesRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.Luggage.Luggage, LuggageData>);

        protected override string GetId(LuggageData d) => d.Id;

        protected override global::Airport.Domain.Luggage.Luggage GetObject(LuggageData d) => new global::Airport.Domain.Luggage.Luggage(d);

        protected override void SetId(LuggageData d, string id) => d.Id = id;
    }
}
