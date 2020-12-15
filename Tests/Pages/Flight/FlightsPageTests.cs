using Airport.Aids;
using Airport.Data.AirlineCompany;
using Airport.Data.Airport;
using Airport.Data.Flight;
using Airport.Data.StopOver;
using Airport.Domain.AirlineCompany;
using Airport.Domain.Api.ApiCity;
using Airport.Domain.Api.ApiCountry;
using Airport.Domain.Flight;
using Airport.Domain.StopOver;
using Airport.Facade.AirlineCompany;
using Airport.Facade.Airport;
using Airport.Facade.Flight;
using Airport.Facade.StopOver;
using Airport.Infra.AirlineCompany;
using Airport.Infra.Api;
using Airport.Pages;
using Airport.Pages.Flight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Flight
{
    [TestClass]
    public class FlightsPageTests : AbstractClassTests
        <FlightsPage, CommonPage<IFlightsRepository, global::Airport.Domain.Flight.Flight, FlightView, FlightData>>
    {
        private class TestClass : FlightsPage
        {
            internal TestClass(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p, IStopOversRepository s, IAirlineCompaniesRepository ac) : base(r, c, p, s, ac) { }
        }
        private class FlightsRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.Flight.Flight, FlightData>,
            IFlightsRepository
        { }

        private class StopOversRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.StopOver.StopOver, StopOverData>,
            IStopOversRepository
        { }
        private class AirlineCompaniesRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.AirlineCompany.AirlineCompany, AirlineCompanyData>,
            IAirlineCompaniesRepository
        { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var r = new FlightsRepository();
            var c = new ApiCountriesRepository();
            var p = new ApiCitiesRepository();
            var s = new StopOversRepository();
            var ac = new AirlineCompaniesRepository();
            obj = new TestClass(r, c, p, s, ac);
        }

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<FlightView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Flights", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/Flight/Flights", obj.PageUrl);

        [TestMethod]
        public void GetPageSubTitleTest() => Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<FlightView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<FlightData>();
            var view = obj.ToView(new global::Airport.Domain.Flight.Flight(data));
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void AirlineCompaniesTest()
        {
            var x = GetRandom.Object<AirlineCompanyData>();
            var y = GetRandom.Object<AirlineCompanyView>();
            TestArePropertyValuesNotEqual(x, y);
            Copy.Members(x, y);
            TestArePropertyValuesEqual(x, y);
        }

        [TestMethod]
        public void AirportsTest()
        {
            var x = GetRandom.Object<AirportData>();
            var y = GetRandom.Object<AirportView>();
            TestArePropertyValuesNotEqual(x, y);
            Copy.Members(x, y);
            TestArePropertyValuesEqual(x, y);
        }
        [TestMethod]
        public void CountriesTest() => IsReadOnlyProperty(obj, nameof(obj.Countries), obj.Countries);
        
        [TestMethod]
        public void CitiesTest() => IsReadOnlyProperty(obj, nameof(obj.Cities), obj.Cities);

        [TestMethod]
        public void StopOversTest() => IsReadOnlyProperty(obj, nameof(obj.StopOvers), obj.StopOvers);

        [TestMethod]
        public void CompaniesTest() => IsReadOnlyProperty(obj, nameof(obj.Companies), obj.Companies);
    }
}
