using Airport.Aids;
using Airport.Data.AirportOfFlight;
using Airport.Facade.AirportOfFlight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.AirportOfFlight
{
    [TestClass]
    public class AirportOfFlightViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(AirportOfFlightViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<AirportOfFlightView>();
            var data = AirportOfFlightViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<AirportOfFlightData>();
            var view = AirportOfFlightViewFactory.Create(new global::Airport.Domain.AirportOfFlight.AirportOfFlight(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
