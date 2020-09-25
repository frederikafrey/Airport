using System;
using Airport.Data.AirportOfFlight;
using Airport.Infra;
using Airport.Infra.AirportOfFlight;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.AirportOfFlight
{
    [TestClass]
    public class AirportOfFlightsRepositoryTests : RepositoryTests<AirportOfFlightsRepository, global::Airport.Domain.AirportOfFlight.AirportOfFlight, AirportOfFlightData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            DbSet = ((AirportDbContext)db).AirportOfFlights;
            obj = new AirportOfFlightsRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.AirportOfFlight.AirportOfFlight, AirportOfFlightData>);

        protected override string GetId(AirportOfFlightData d) => d.Id;

        protected override global::Airport.Domain.AirportOfFlight.AirportOfFlight GetObject(AirportOfFlightData d) => new global::Airport.Domain.AirportOfFlight.AirportOfFlight(d);

        protected override void SetId(AirportOfFlightData d, string id) => d.Id = id;
    }
}
