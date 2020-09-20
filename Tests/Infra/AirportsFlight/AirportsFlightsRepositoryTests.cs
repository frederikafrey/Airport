using System;
using Airport.Data.AirportsFlight;
using Airport.Infra;
using Airport.Infra.AirportsFlight;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.AirportsFlight
{
    [TestClass]
    public class AirportsFlightsRepositoryTests : RepositoryTests<AirportsFlightsRepository, global::Airport.Domain.AirportsFlight.AirportsFlight, AirportsFlightData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            dbSet = ((AirportDbContext)db).AirportsFlights;
            obj = new AirportsFlightsRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.AirportsFlight.AirportsFlight, AirportsFlightData>);

        protected override string GetId(AirportsFlightData d) => d.Id;

        protected override global::Airport.Domain.AirportsFlight.AirportsFlight GetObject(AirportsFlightData d) => new global::Airport.Domain.AirportsFlight.AirportsFlight(d);

        protected override void SetId(AirportsFlightData d, string id) => d.Id = id;
    }
}
