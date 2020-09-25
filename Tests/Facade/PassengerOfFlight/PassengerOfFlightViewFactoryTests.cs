using Airport.Aids;
using Airport.Data.PassengerOfFlight;
using Airport.Facade.PassengerOfFlight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.PassengerOfFlight
{

    [TestClass]
    public class PassengerOfFlightViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(PassengerOfFlightViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<PassengerOfFlightView>();
            var data = PassengerOfFlightViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<PassengerOfFlightData>();
            var view = PassengerOfFlightViewFactory.Create(new global::Airport.Domain.PassengerOfFlight.PassengerOfFlight(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
