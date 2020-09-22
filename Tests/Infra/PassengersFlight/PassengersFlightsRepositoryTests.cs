using System;
using Airport.Data.PassengersFlight;
using Airport.Infra;
using Airport.Infra.PassengersFlight;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.PassengersFlight
{
    [TestClass]
    public class PassengersFlightsRepositoryTests : RepositoryTests<PassengersFlightsRepository, global::Airport.Domain.PassengersFlight.PassengersFlight, PassengersFlightData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            DbSet = ((AirportDbContext)db).PassengersFlights;
            obj = new PassengersFlightsRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.PassengersFlight.PassengersFlight, PassengersFlightData>);

        protected override string GetId(PassengersFlightData d) => d.Id;

        protected override global::Airport.Domain.PassengersFlight.PassengersFlight GetObject(PassengersFlightData d) => new global::Airport.Domain.PassengersFlight.PassengersFlight(d);

        protected override void SetId(PassengersFlightData d, string id) => d.Id = id;
    }
}
