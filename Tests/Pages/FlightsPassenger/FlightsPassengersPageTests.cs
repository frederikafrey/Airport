using Airport.Aids;
using Airport.Data.Flight;
using Airport.Data.FlightsPassenger;
using Airport.Data.PassengersFlight;
using Airport.Domain.Flight;
using Airport.Domain.FlightsPassenger;
using Airport.Domain.PassengersFlight;
using Airport.Facade.FlightsPassenger;
using Airport.Pages;
using Airport.Pages.FlightsPassenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.FlightsPassenger
{
    [TestClass]
    public class FlightsPassengersPageTests : AbstractClassTests
        <FlightsPassengerPage, CommonPage<IFlightsPassengersRepository, global::Airport.Domain.FlightsPassenger.FlightsPassenger, FlightsPassengerView, FlightsPassengerData>>
    {
        private class TestClass : FlightsPassengerPage
        {
            internal TestClass(IFlightsPassengersRepository r, IFlightsRepository p, IPassengersFlightsRepository t) : base(r, p, t) { }
        }
        private class TrainRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.PassengersFlight.PassengersFlight, PassengersFlightData>,
            IPassengersFlightsRepository
        { }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.FlightsPassenger.FlightsPassenger, FlightsPassengerData>,
            IFlightsPassengersRepository
        { }

        private class TermRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.Flight.Flight, FlightData>,
            IFlightsRepository
        { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var r = new TestRepository();
            var p = new TermRepository();
            var t = new TrainRepository();
            obj = new TestClass(r, p, t);
        }

        public static string Id(string head, string tail) => $"{head}.{tail}";

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<FlightsPassengerView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.PassengersFlightId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Flight Passengers", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/FlightsPassenger/FlightsPassengers", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<FlightsPassengerView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<FlightsPassengerData>();
            var view = obj.ToView(new global::Airport.Domain.FlightsPassenger.FlightsPassenger(data));
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void FlightIdTest()
        {
            var item = GetRandom.Object<FlightsPassengerView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.PassengersFlightId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PassengersFlightIdTest()
        {
            var item = GetRandom.Object<FlightsPassengerView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.PassengersFlightId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void IdTest()
        {
            var item = GetRandom.Object<FlightsPassengerView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.PassengersFlightId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void GetFlightNameTest()
        {
            var item = GetRandom.Object<FlightsPassengerView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.PassengersFlightId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }
        [TestMethod]
        public void GetPassengersFlightNameTest()
        {
            var item = GetRandom.Object<FlightsPassengerView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.PassengersFlightId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void GetPageSubTitleTest() => Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());
    }
}
