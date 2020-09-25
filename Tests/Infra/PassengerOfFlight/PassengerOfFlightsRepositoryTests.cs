using System;
using Airport.Data.PassengerOfFlight;
using Airport.Infra;
using Airport.Infra.PassengerOfFlight;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.PassengerOfFlight
{
    [TestClass]
    public class PassengerOfFlightsRepositoryTests : RepositoryTests<PassengerOfFlightsRepository, global::Airport.Domain.PassengerOfFlight.PassengerOfFlight, PassengerOfFlightData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            DbSet = ((AirportDbContext)db).PassengerOfFlights;
            obj = new PassengerOfFlightsRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.PassengerOfFlight.PassengerOfFlight, PassengerOfFlightData>);

        protected override string GetId(PassengerOfFlightData d) => d.Id;

        protected override global::Airport.Domain.PassengerOfFlight.PassengerOfFlight GetObject(PassengerOfFlightData d) => new global::Airport.Domain.PassengerOfFlight.PassengerOfFlight(d);

        protected override void SetId(PassengerOfFlightData d, string id) => d.Id = id;
    }
}
