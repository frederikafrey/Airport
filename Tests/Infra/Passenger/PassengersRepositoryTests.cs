using System;
using Airport.Data.Passenger;
using Airport.Infra;
using Airport.Infra.Passenger;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.Passenger
{
    [TestClass]
    public class PassengersRepositoryTests : RepositoryTests<PassengersRepository, global::Airport.Domain.Passenger.Passenger, PassengerData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            dbSet = ((AirportDbContext)db).Passengers;
            obj = new PassengersRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.Passenger.Passenger, PassengerData>);

        protected override string GetId(PassengerData d) => d.Id;

        protected override global::Airport.Domain.Passenger.Passenger GetObject(PassengerData d) => new global::Airport.Domain.Passenger.Passenger(d);

        protected override void SetId(PassengerData d, string id) => d.Id = id;
    }
}
