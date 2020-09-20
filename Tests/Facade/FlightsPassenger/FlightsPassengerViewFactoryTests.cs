using Airport.Aids;
using Airport.Data.FlightsPassenger;
using Airport.Facade.FlightsPassenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.FlightsPassenger
{

    [TestClass]
    public class FlightsPassengerViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(FlightsPassengerViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<FlightsPassengerView>();
            var data = FlightsPassengerViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<FlightsPassengerData>();
            var view = FlightsPassengerViewFactory.Create(new global::Airport.Domain.FlightsPassenger.FlightsPassenger(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
