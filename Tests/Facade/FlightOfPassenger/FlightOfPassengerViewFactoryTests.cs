using Airport.Aids;
using Airport.Data.FlightOfPassenger;
using Airport.Facade.FlightOfPassenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.FlightOfPassenger
{
    [TestClass]
    public class FlightOfPassengerViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(FlightOfPassengerViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<FlightOfPassengerView>();
            var data = FlightOfPassengerViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<FlightOfPassengerData>();
            var view = FlightOfPassengerViewFactory.Create(new global::Airport.Domain.FlightOfPassenger.FlightOfPassenger(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
