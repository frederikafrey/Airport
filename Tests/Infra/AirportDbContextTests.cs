using System;
using System.Linq;
using System.Linq.Expressions;
using Airport.Aids;
using Airport.Data.AirlinesCompany;
using Airport.Data.Airport;
using Airport.Data.AirportsFlight;
using Airport.Data.Flight;
using Airport.Data.FlightsPassenger;
using Airport.Data.Luggage;
using Airport.Data.Passenger;
using Airport.Data.PassengersFlight;
using Airport.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra
{
    [TestClass]
    public class AirportDbContextTests : BaseClassTests<AirportDbContext, DbContext>
    {
        private DbContextOptions<AirportDbContext> options;
        private class TestClass : AirportDbContext
        {
            public TestClass(DbContextOptions<AirportDbContext> o) : base(o) { }
            public ModelBuilder RunOnModelCreating()
            {
                var set = new ConventionSet();
                var mb = new ModelBuilder(set);
                OnModelCreating(mb);
                return mb;
            }
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            options = new DbContextOptionsBuilder<AirportDbContext>().UseInMemoryDatabase("TestDb").Options;
            obj = new AirportDbContext(options);
        }

        [TestMethod]
        public void InitializeTablesTest()
        {
            static void TestKey<T>(IMutableEntityType entity, params Expression<Func<T, object>>[] values)
            {
                var key = entity.FindPrimaryKey();

                if (values is null) Assert.IsNull(key);
                else
                    foreach (var v in values)
                    {
                        var name = GetMember.Name(v);
                        Assert.IsNotNull(key.Properties.FirstOrDefault(x => x.Name == name));
                    }
            }

            static void TestEntity<T>(ModelBuilder b, params Expression<Func<T, object>>[] values)
            {
                var name = typeof(T).FullName ?? string.Empty;
                var entity = b.Model.FindEntityType(name);
                Assert.IsNotNull(entity, name);
                TestKey(entity, values);
            }

            AirportDbContext.InitializeTables(null);
            var o = new TestClass(options);
            var builder = o.RunOnModelCreating();
            AirportDbContext.InitializeTables(builder);
            TestEntity<AirlinesCompanyData>(builder);
            TestEntity<AirportData>(builder);
            TestEntity<AirportsFlightData>(builder, x => x.FlightId, x => x.AirportId);
            TestEntity<FlightData>(builder, x => x.StartingPointId, x => x.FinalPointId, x=> x.PlaneId);
            TestEntity<FlightsPassengerData>(builder, x => x.FlightId, x => x.PassengersFlightId);
            TestEntity<LuggageData>(builder, x => x.PassengerId);
            TestEntity<PassengerData>(builder);
            TestEntity<PassengersFlightData>(builder, x => x.PassengerId, x => x.FlightsPassengerId, x => x.StartDestinationId, x => x.FinalDestinationId);
        }

        [TestMethod]
        public void AirlinesCompaniesTest() => IsNullableProperty(obj, nameof(obj.AirlinesCompanies), typeof(DbSet<AirlinesCompanyData>));

        [TestMethod]
        public void AirportsTest() => IsNullableProperty(obj, nameof(obj.Airports), typeof(DbSet<AirportData>));

        [TestMethod]
        public void AirportsFlightsTest() => IsNullableProperty(obj, nameof(obj.AirportsFlights), typeof(DbSet<AirportsFlightData>));

        [TestMethod]
        public void FlightsTest() => IsNullableProperty(obj, nameof(obj.Flights), typeof(DbSet<FlightData>));

        [TestMethod]
        public void FlightsPassengersTest() => IsNullableProperty(obj, nameof(obj.FlightsPassengers), typeof(DbSet<FlightsPassengerData>));

        [TestMethod]
        public void LuggagesTest() => IsNullableProperty(obj, nameof(obj.Luggages), typeof(DbSet<LuggageData>));

        [TestMethod]
        public void PassengersTest() => IsNullableProperty(obj, nameof(obj.Passengers), typeof(DbSet<PassengerData>));

        [TestMethod]
        public void PassengersFlightsTest() => IsNullableProperty(obj, nameof(obj.PassengersFlights), typeof(DbSet<PassengersFlightData>));
    }
}
