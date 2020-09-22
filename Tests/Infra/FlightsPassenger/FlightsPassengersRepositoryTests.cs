using System;
using Airport.Data.FlightsPassenger;
using Airport.Infra;
using Airport.Infra.FlightsPassenger;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.FlightsPassenger
{
    [TestClass]
    public class FlightsPassengersRepositoryTests : RepositoryTests<FlightsPassengersRepository, global::Airport.Domain.FlightsPassenger.FlightsPassenger, FlightsPassengerData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            DbSet = ((AirportDbContext)db).FlightsPassengers;
            obj = new FlightsPassengersRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.FlightsPassenger.FlightsPassenger, FlightsPassengerData>);

        protected override string GetId(FlightsPassengerData d) => d.Id;

        protected override global::Airport.Domain.FlightsPassenger.FlightsPassenger GetObject(FlightsPassengerData d) => new global::Airport.Domain.FlightsPassenger.FlightsPassenger(d);

        protected override void SetId(FlightsPassengerData d, string id) => d.Id = id;
    }
}
