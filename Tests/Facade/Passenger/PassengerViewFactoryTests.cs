using Airport.Aids;
using Airport.Data.Passenger;
using Airport.Facade.Passenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.Passenger
{
    [TestClass]
    public class PassengerViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(PassengerViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<PassengerView>();
            var data = PassengerViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<PassengerData>();
            var view = PassengerViewFactory.Create(new global::Airport.Domain.Passenger.Passenger(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
