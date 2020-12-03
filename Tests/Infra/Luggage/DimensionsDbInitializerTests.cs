using Airport.Infra;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.Luggage
{
    [TestClass]
    public class DimensionsDbInitializerTests: DbInitializerTests<AirportDbContext>
    {
        //[TestInitialize]
        //public override void TestInitialize()
        //{
        //    base.TestInitialize();
        //    type = typeof(DimensionsDbInitializer);
        //    db = new AirportDbContext(options);
        //    RemoveAll(db.Airports);
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
        //    DimensionsDbInitializer.Initialize(db);
        //    Assert.AreEqual(3, db.Luggages.Count());
        //}
    }
}
