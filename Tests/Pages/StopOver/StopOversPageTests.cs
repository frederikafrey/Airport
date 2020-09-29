using Airport.Aids;
using Airport.Data.Flight;
using Airport.Data.FlightOfPassenger;
using Airport.Data.StopOver;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.StopOver;
using Airport.Facade.StopOver;
using Airport.Pages;
using Airport.Pages.StopOver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.StopOver
{
    [TestClass]
    public class StopOversPageTests : AbstractClassTests
        <StopOversPage, CommonPage<IStopOversRepository, global::Airport.Domain.StopOver.StopOver, StopOverView, StopOverData>>
    {
        private class TestClass : StopOversPage
        {
            internal TestClass(IStopOversRepository r, IFlightsRepository p, IFlightOfPassengersRepository t) : base(r, p, t) { }
        }
        private class TrainRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerData>,
            IFlightOfPassengersRepository
        { }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.StopOver.StopOver, StopOverData>,
            IStopOversRepository
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
            var item = GetRandom.Object<StopOverView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.FlightOfPassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Flight Passengers", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/StopOver/StopOvers", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<StopOverView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<StopOverData>();
            var view = obj.ToView(new global::Airport.Domain.StopOver.StopOver(data));
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void FlightIdTest()
        {
            var item = GetRandom.Object<StopOverView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.FlightOfPassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PassengersFlightIdTest()
        {
            var item = GetRandom.Object<StopOverView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.FlightOfPassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void IdTest()
        {
            var item = GetRandom.Object<StopOverView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.FlightOfPassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void GetFlightNameTest()
        {
            var item = GetRandom.Object<StopOverView>();
            obj.Item = item;
            string a = Id(item.FlightId, item.FlightOfPassengerId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }
        [TestMethod]
        public void GetPassengersFlightNameTest()
        {
            var item = GetRandom.Object<StopOverView>();
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
