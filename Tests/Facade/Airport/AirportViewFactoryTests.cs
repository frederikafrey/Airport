using Airport.Aids;
using Airport.Data.Airport;
using Airport.Facade.Airport;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.Airport
{
    [TestClass]
    public class AirportViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(AirportViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<AirportView>();
            var data = AirportViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<AirportData>();
            var view = AirportViewFactory.Create(new global::Airport.Domain.Airport.Airport(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
