using Airport.Infra;
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
        //    type = typeof(AirlineCompaniesDbInitializer);
        //    db = new AirportDbContext(options);
        //    RemoveAll(db.AirlineCompanies);
        //}

        //[TestMethod]
        //public void InitializeAirlineCompaniesTest()
        //{
        //    List<string> airports = new List<string>() { "SWE", "Air Leap", "AirLeap.com" };
            
        //    var air = new[] {
        //        new AirlineCompanyData {
        //            Id = "SWE", Name = "Air Leap", Address = "AirLeap.com" }
        //        }; 
            
        //    Assert.AreEqual(airports[0], air);
        //}
    }
}
