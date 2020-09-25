using Airport.Aids;
using Airport.Data.PassengersFlight;
using Airport.Domain.PassengersFlight;
using Airport.Facade.PassengersFlight;
using Airport.Pages;
using Airport.Pages.PassengersFlight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.PassengersFlight
{
    [TestClass]
    public class PassengersFlightsPageTests : AbstractClassTests
        <PassengersFlightsPage, CommonPage<IPassengersFlightsRepository, global::Airport.Domain.PassengersFlight.PassengersFlight, PassengersFlightView, PassengersFlightData>>
    {
        public class TestClass : PassengersFlightsPage
        {
            internal TestClass(IPassengersFlightsRepository r) : base(r) { }
        }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.PassengersFlight.PassengersFlight, PassengersFlightData>,
            IPassengersFlightsRepository
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
            var item = GetRandom.Object<PassengersFlightView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Passenger Flights", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/PassengersFlight/PassengersFlights", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<PassengersFlightView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<PassengersFlightData>();
            var view = obj.ToView(new global::Airport.Domain.PassengersFlight.PassengersFlight(data));
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void GetPageSubTitleTest() => Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());


        [TestMethod]
        public void NamesTest()
        {
            var x = GetRandom.Object<PassengersFlightData>();
            var y = GetRandom.Object<PassengersFlightView>();
            TestArePropertyValuesNotEqual(x, y);
            Copy.Members(x, y);
            TestArePropertyValuesEqual(x, y);
        }
    }
}
