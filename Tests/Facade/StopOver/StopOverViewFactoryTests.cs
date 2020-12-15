using Airport.Aids;
using Airport.Data.StopOver;
using Airport.Facade.StopOver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.StopOver
{
    [TestClass]
    public class StopOverViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(StopOverViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<StopOverView>();
            var data = StopOverViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<StopOverData>();
            var view = StopOverViewFactory.Create(new global::Airport.Domain.StopOver.StopOver(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
