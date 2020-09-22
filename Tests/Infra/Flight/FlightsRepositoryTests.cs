using System;
using Airport.Data.Flight;
using Airport.Infra;
using Airport.Infra.Flight;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.Flight
{
    [TestClass]
    public class FlightsRepositoryTests : RepositoryTests<FlightsRepository, global::Airport.Domain.Flight.Flight, FlightData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            DbSet = ((AirportDbContext)db).Flights;
            obj = new FlightsRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.Flight.Flight, FlightData>);

        protected override string GetId(FlightData d) => d.Id;

        protected override global::Airport.Domain.Flight.Flight GetObject(FlightData d) => new global::Airport.Domain.Flight.Flight(d);

        protected override void SetId(FlightData d, string id) => d.Id = id;
    }
}
