using System.Linq;
using Airport.Infra;
using Airport.Infra.AirlineCompany;
using Airport.Infra.Airport;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.AirlineCompany
{
    [TestClass]
    public class AirlineCompaniesDbInitializerTests: DbInitializerTests<AirportDbContext>
    {
        //[TestInitialize]
        //public override void TestInitialize()
        //{
        //    base.TestInitialize();
        //    type = typeof(AirportsDbInitializer);
        //    db = new AirportDbContext(options);
        //    RemoveAll(db.AirlineCompanies);
        //}

        //[TestMethod]
        //public void InitializeTest()
        //{
        //    AirlineCompaniesDbInitializer.Initialize(db);
        //    Assert.AreEqual(3, db.AirlineCompanies.Count());
        //}
    }
}
