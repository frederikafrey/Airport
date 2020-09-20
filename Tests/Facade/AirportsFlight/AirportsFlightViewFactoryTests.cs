using Airport.Aids;
using Airport.Data.AirportsFlight;
using Airport.Facade.AirportsFlight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.AirportsFlight
{
    [TestClass]
    public class AirportsFlightViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(AirportsFlightViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<AirportsFlightView>();
            var data = AirportsFlightViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<AirportsFlightData>();
            var view = AirportsFlightViewFactory.Create(new global::Airport.Domain.AirportsFlight.AirportsFlight(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
