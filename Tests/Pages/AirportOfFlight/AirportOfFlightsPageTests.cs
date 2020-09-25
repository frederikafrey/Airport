using Airport.Aids;
using Airport.Data.AirportOfFlight;
using Airport.Domain.AirportOfFlight;
using Airport.Facade.AirportOfFlight;
using Airport.Pages;
using Airport.Pages.AirportOfFlight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.AirportOfFlight
{
    [TestClass]
    public class AirportOfFlightsPageTests : AbstractClassTests
        <AirportOfFlightPage, CommonPage<IAirportOfFlightsRepository, global::Airport.Domain.AirportOfFlight.AirportOfFlight, AirportOfFlightView, AirportOfFlightData>>
    {
        private class TestClass : AirportOfFlightPage
        {
            internal TestClass(IAirportOfFlightsRepository r) : base(r) { }
        }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.AirportOfFlight.AirportOfFlight, AirportOfFlightData>,
            IAirportOfFlightsRepository
        { }


        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var r = new TestRepository();
            obj = new TestClass(r);
        }

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<AirportOfFlightView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Airport Flights", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/AirportOfFlight/AirportOfFlights", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<AirportOfFlightView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<AirportOfFlightData>();
            var view = obj.ToView(new global::Airport.Domain.AirportOfFlight.AirportOfFlight(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
