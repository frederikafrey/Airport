using Airport.Aids;
using Airport.Data.Flight;
using Airport.Facade.Flight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.Flight
{
    [TestClass]
    public class FlightViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(FlightViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<FlightView>();
            var data = FlightViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<FlightData>();
            var view = FlightViewFactory.Create(new global::Airport.Domain.Flight.Flight(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
