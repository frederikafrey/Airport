﻿using Airport.Aids;
using Airport.Data.Luggage;
using Airport.Data.Passenger;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Facade.Luggage;
using Airport.Pages;
using Airport.Pages.Luggage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.Luggage
{
    [TestClass]
    public class LuggagesPageTests : AbstractClassTests
       <LuggagesPage, CommonPage<ILuggagesRepository, global::Airport.Domain.Luggage.Luggage, LuggageView, LuggageData>>
    {
        public class TestClass : LuggagesPage
        {
            internal TestClass(ILuggagesRepository r, IPassengersRepository p) : base(r, p) { }
        }
        private class LuggagesRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.Luggage.Luggage, LuggageData>,
            ILuggagesRepository
        { }

        private class PassengersRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.Passenger.Passenger, PassengerData>,
            IPassengersRepository
        { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var r = new LuggagesRepository();
            var p = new PassengersRepository();
            obj = new TestClass(r, p);
        }

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<LuggageView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Luggage", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/Luggage/Luggages", obj.PageUrl);

        [TestMethod]
        public void GetPageSubTitleTest() => Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<LuggageView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<LuggageData>();
            var view = obj.ToView(new global::Airport.Domain.Luggage.Luggage(data));
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void LuggagesTest()
        {
            var x = GetRandom.Object<LuggageData>();
            var y = GetRandom.Object<LuggageView>();
            TestArePropertyValuesNotEqual(x, y);
            Copy.Members(x, y);
            TestArePropertyValuesEqual(x, y);
        }
        
        [TestMethod]
        public void DimensionsTest() => IsReadOnlyProperty(obj, nameof(obj.Dimensions), obj.Dimensions);

        [TestMethod]
        public void WeightTest() => IsReadOnlyProperty(obj, nameof(obj.Weight), obj.Weight);

        [TestMethod]
        public void PassengersTest() => IsReadOnlyProperty(obj, nameof(obj.Passengers), obj.Passengers);
    }
}
