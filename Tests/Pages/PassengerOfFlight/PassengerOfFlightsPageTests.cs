using Airport.Aids;
using Airport.Data.Flight;
using Airport.Data.FlightOfPassenger;
using Airport.Data.PassengerOfFlight;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.PassengerOfFlight;
using Airport.Facade.PassengerOfFlight;
using Airport.Pages;
using Airport.Pages.PassengerOfFlight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.PassengerOfFlight
{
    [TestClass]
    public class PassengerOfFlightsPageTests : AbstractClassTests
        <PassengerOfFlightsPage, CommonPage<IPassengerOfFlightsRepository, global::Airport.Domain.PassengerOfFlight.PassengerOfFlight, PassengerOfFlightView, PassengerOfFlightData>>
    {
        private class TestClass : PassengerOfFlightsPage
        {
            internal TestClass(IPassengerOfFlightsRepository r, IFlightsRepository p, IFlightOfPassengersRepository t) : base(r, p, t) { }
        }
        private class TrainRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerData>,
            IFlightOfPassengersRepository
        { }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.PassengerOfFlight.PassengerOfFlight, PassengerOfFlightData>,
            IPassengerOfFlightsRepository
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
            var item = GetRandom.Object<PassengerOfFlightView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.FlightOfPassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Flight Passengers", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/PassengerOfFlight/PassengerOfFlights", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<PassengerOfFlightView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<PassengerOfFlightData>();
            var view = obj.ToView(new global::Airport.Domain.PassengerOfFlight.PassengerOfFlight(data));
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void FlightIdTest()
        {
            var item = GetRandom.Object<PassengerOfFlightView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.FlightOfPassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PassengersFlightIdTest()
        {
            var item = GetRandom.Object<PassengerOfFlightView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.FlightOfPassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void IdTest()
        {
            var item = GetRandom.Object<PassengerOfFlightView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.FlightOfPassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void GetFlightNameTest()
        {
            var item = GetRandom.Object<PassengerOfFlightView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.FlightOfPassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }
        [TestMethod]
        public void GetPassengersFlightNameTest()
        {
            var item = GetRandom.Object<PassengerOfFlightView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.FlightOfPassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void GetPageSubTitleTest() => Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());
    }
}
