﻿using Airport.Aids;
using Airport.Data.Flight;
using Airport.Data.FlightOfPassenger;
using Airport.Data.Luggage;
using Airport.Data.Passenger;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Facade.FlightOfPassenger;
using Airport.Infra.Flight;
using Airport.Infra.FlightOfPassenger;
using Airport.Infra.Luggage;
using Airport.Infra.Passenger;
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
            internal TestClass(IFlightOfPassengersRepository r, IPassengersRepository p, IFlightsRepository f, ILuggagesRepository l) : base(r, p, f, l) { }
            public override string ItemId { get; }
        }

        private class FlightOfPassengersRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerData>,
            IFlightOfPassengersRepository
        { }

        private class PassengersRepository : BaseTestRepositoryForUniqueEntity<
                global::Airport.Domain.Passenger.Passenger, PassengerData>,
            IPassengersRepository
        { }

        private class FlightsRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.Flight.Flight, FlightData>,
            IFlightsRepository
        { }

        private class LuggagesRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.Luggage.Luggage, LuggageData>,
            ILuggagesRepository
        { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var r = new FlightOfPassengersRepository();
            var p = new PassengersRepository();
            var f = new FlightsRepository();
            var l = new LuggagesRepository();
            obj = new TestClass(r, p, f, l);
        }

        public static string Id(string head, string tail) => $"{head}.{tail}";

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            string a = Id(item.PassengerId, item.FlightId);
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
        public void PassengersTest()
        {
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            string a = Id(item.PassengerId, item.FlightId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void IdTest()
        {
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            string a = Id(item.PassengerId, item.FlightId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void GetFlightOfPassengerNameTest()
        {
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            string a = Id(item.PassengerId, item.FlightId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }


        [TestMethod]
        public void GetPassengerNameTest()
        {
            var item = GetRandom.Object<FlightOfPassengerView>();
            obj.Item = item;
            string a = Id(item.PassengerId, item.FlightId);
            Assert.AreEqual(a, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }
    }
}
