using Airport.Aids;
using Airport.Data.Luggage;
using Airport.Facade.Luggage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.Luggage
{
    [TestClass]
    public class LuggageViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(LuggageViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<LuggageView>();
            var data = LuggageViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<LuggageData>();
            var view = LuggageViewFactory.Create(new global::Airport.Domain.Luggage.Luggage(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
