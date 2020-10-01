using Airport.Aids;
using Airport.Data.FlightOfPassenger;
using Airport.Data.Passenger;
using Airport.Data.StopOver;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Passenger;
using Airport.Domain.StopOver;
using Airport.Facade.FlightOfPassenger;
using Airport.Pages;
using Airport.Pages.FlightOfPassenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.FlightOfPassenger
{
    [TestClass]
    public class FlightOfPassengersPageTests : AbstractClassTests
        <FlightOfPassengersPage, CommonPage<IFlightOfPassengersRepository, global::Airport.Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerView, FlightOfPassengerData>>
    {
        public class TestClass : FlightOfPassengersPage
        {
            internal TestClass(IFlightOfPassengersRepository r, IStopOversRepository p, IPassengersRepository t) : base(r, p, t) { }
        }
        private class FlightOfPassengersRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerData>,
            IFlightOfPassengersRepository
        { }

        private class StopOversRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.StopOver.StopOver, StopOverData>,
            IStopOversRepository
        { }

        private class PassengersRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.Passenger.Passenger, PassengerData>,
            IPassengersRepository
        { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var r = new FlightOfPassengersRepository();
            var p = new StopOversRepository();
            var t = new PassengersRepository();
            obj = new TestClass(r, p, t);
        }

        public static string Id(string head, string tail) => $"{head}.{tail}";

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            string a = Id(item.StopOverId, item.PassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Flight Of Passengers", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/FlightOfPassenger/FlightOfPassengers", obj.PageUrl);

        [TestMethod]
        public void GetPageSubTitleTest() => Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<FlightOfPassengerView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<FlightOfPassengerData>();
            var view = obj.ToView(new global::Airport.Domain.FlightOfPassenger.FlightOfPassenger(data));
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void PassengerIdTest()
        {
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            string a = Id(item.StopOverId, item.PassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void StopOverIdTest()
        {
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            string a = Id(item.StopOverId, item.PassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void IdTest()
        {
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            string a = Id(item.StopOverId, item.PassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void GetFlightOfPassengerNameTest()
        {
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            string a = Id(item.StopOverId, item.PassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void GetStopOverNameTest()
        {
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            string a = Id(item.StopOverId, item.PassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void GetPassengerNameTest()
        {
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            string a = Id(item.StopOverId, item.PassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }
    }
}
