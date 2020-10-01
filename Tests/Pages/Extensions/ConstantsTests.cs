using Airport.Pages.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Extensions
{
    [TestClass]
    public class ConstantsTests: BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(Constants);
        [TestMethod] public void UnspecifiedTest() => Assert.AreEqual("Unspecified", Constants.Unspecified);
        [TestMethod] public void CreateNewLinkTitleTest() => Assert.AreEqual("Create New", Constants.CreateNewLinkTitle);
        [TestMethod] public void EditLinkTitleTest() => Assert.AreEqual( "Edit", Constants.EditLinkTitle);
        [TestMethod] public void DetailsLinkTitleTest() => Assert.AreEqual( "Details", Constants.DetailsLinkTitle);
        [TestMethod] public void DeleteLinkTitleTest() => Assert.AreEqual("Delete", Constants.DeleteLinkTitle);
        [TestMethod] public void SelectLinkTitleTest() => Assert.AreEqual("Select", Constants.SelectLinkTitle);

        [TestMethod] public void AirlineCompaniesPageTitleTest() => Assert.AreEqual("Airline AirlineCompanies", Constants.AirlineCompaniesPageTitle);
        [TestMethod] public void AirportsPageTitleTest() => Assert.AreEqual("Airports", Constants.AirportsPageTitle);
        [TestMethod] public void FlightsPageTitleTest() => Assert.AreEqual("Flights", Constants.FlightsPageTitle);
        [TestMethod] public void StopOversPageTitleTest() => Assert.AreEqual("Stop Overs", Constants.StopOversPageTitle);
        [TestMethod] public void LuggagesPageTitleTest() => Assert.AreEqual("Luggage", Constants.LuggagesPageTitle);
        [TestMethod] public void PassengersPageTitleTest() => Assert.AreEqual("Passengers", Constants.PassengersPageTitle);
        [TestMethod] public void FlightOfPassengersPageTitleTest() => Assert.AreEqual("Flight Of Passengers", Constants.FlightOfPassengersPageTitle);
    }
}
