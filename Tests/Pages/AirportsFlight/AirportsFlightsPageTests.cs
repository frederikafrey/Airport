using Airport.Aids;
using Airport.Data.AirportsFlight;
using Airport.Domain.AirportsFlight;
using Airport.Facade.AirportsFlight;
using Airport.Pages;
using Airport.Pages.AirportsFlight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.AirportsFlight
{
    [TestClass]
    public class AirportsFlightsPageTests : AbstractClassTests
        <AirportsFlightPage, CommonPage<IAirportsFlightsRepository, global::Airport.Domain.AirportsFlight.AirportsFlight, AirportsFlightView, AirportsFlightData>>
    {
        private class TestClass : AirportsFlightPage
        {
            internal TestClass(IAirportsFlightsRepository r) : base(r) { }
        }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.AirportsFlight.AirportsFlight, AirportsFlightData>,
            IAirportsFlightsRepository
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
            var item = GetRandom.Object<AirportsFlightView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Airport Flights", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/AirportsFlight/AirportsFlights", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<AirportsFlightView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<AirportsFlightData>();
            var view = obj.ToView(new global::Airport.Domain.AirportsFlight.AirportsFlight(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
