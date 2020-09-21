using Airport.Aids;
using Airport.Data.Passenger;
using Airport.Data.PassengersFlight;
using Airport.Domain.Passenger;
using Airport.Domain.PassengersFlight;
using Airport.Facade.Passenger;
using Airport.Pages;
using Airport.Pages.Passenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Passenger
{
    [TestClass]
    public class PassengersPageTests : AbstractClassTests
        <PassengersPage, CommonPage<IPassengersRepository, global::Airport.Domain.Passenger.Passenger, PassengerView, PassengerData>>
    {
        private class TestClass : PassengersPage
        {
            internal TestClass(IPassengersRepository r) : base(r) { }
        }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.Passenger.Passenger, PassengerData>,
            IPassengersRepository { }

        private class TermRepository : BaseTestRepositoryForUniqueEntity<
                global::Airport.Domain.PassengersFlight.PassengersFlight , PassengersFlightData>,
            IPassengersFlightsRepository { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var r = new TestRepository();
            var t = new TermRepository();
            obj = new TestClass(r);
        }

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<PassengerView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Passengers", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/Passenger/Passengers", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<PassengerView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<PassengerData>();
            var view = obj.ToView(new global::Airport.Domain.Passenger.Passenger(data));
            TestArePropertyValuesEqual(view, data);
        }
    }

}
