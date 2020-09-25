using System;
using Airport.Data.FlightOfPassenger;
using Airport.Infra;
using Airport.Infra.FlightOfPassenger;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.FlightOfPassenger
{
    [TestClass]
    public class FlightOfPassengersRepositoryTests : RepositoryTests<FlightOfPassengersRepository, global::Airport.Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            DbSet = ((AirportDbContext)db).FlightOfPassengers;
            obj = new FlightOfPassengersRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerData>);

        protected override string GetId(FlightOfPassengerData d) => d.Id;

        protected override global::Airport.Domain.FlightOfPassenger.FlightOfPassenger GetObject(FlightOfPassengerData d) => new global::Airport.Domain.FlightOfPassenger.FlightOfPassenger(d);

        protected override void SetId(FlightOfPassengerData d, string id) => d.Id = id;
    }
}
