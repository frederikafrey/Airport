using Airport.Aids;
using Airport.Data.PassengersFlight;
using Airport.Facade.PassengersFlight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.PassengersFlight
{
    [TestClass]
    public class PassengersFlightViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(PassengersFlightViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<PassengersFlightView>();
            var data = PassengersFlightViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<PassengersFlightData>();
            var view = PassengersFlightViewFactory.Create(new global::Airport.Domain.PassengersFlight.PassengersFlight(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
