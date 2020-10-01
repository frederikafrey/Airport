using Airport.Aids;
using Airport.Data.FlightOfPassenger;
using Airport.Domain.FlightOfPassenger;
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
            internal TestClass(IFlightOfPassengersRepository r) : base(r) { }
        }
        private class TestRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerData>,
            IFlightOfPassengersRepository
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
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Flight Of Passengers", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/FlightOfPassenger/FlightOfPassengerId", obj.PageUrl);

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
        public void GetPageSubTitleTest() => Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());


        [TestMethod]
        public void NamesTest()
        {
            var x = GetRandom.Object<FlightOfPassengerData>();
            var y = GetRandom.Object<FlightOfPassengerView>();
            TestArePropertyValuesNotEqual(x, y);
            Copy.Members(x, y);
            TestArePropertyValuesEqual(x, y);
        }
    }
}
