using Airport.Infra;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.Airport
{
    [TestClass]
    public class AirportsDbInitializerTests : DbInitializerTests<AirportDbContext>
    {
        //[TestInitialize]
        //public override void TestInitialize()
        //{
        //    base.TestInitialize();
        //    type = typeof(AirportsDbInitializer);
        //    db = new AirportDbContext(options);
        //    //RemoveAll(db.Airports);
        //    RemoveAll(db.AirlineCompanies);
        //    RemoveAll(db.Flights);
        //    RemoveAll(db.FlightOfPassengers);
        //    RemoveAll(db.Luggages);
        //    RemoveAll(db.Passengers);
        //    RemoveAll(db.StopOvers);
        //}

        //[TestMethod]
        //public void InitializeAirportsTest()
        //{
        //    AirportsDbInitializer.Initialize(db);
        //    Assert.AreEqual(3, db.Airports.Count());
        //}
    }
}
