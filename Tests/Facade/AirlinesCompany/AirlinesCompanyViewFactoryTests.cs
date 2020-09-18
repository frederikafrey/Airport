using Airport.Aids;
using Airport.Data.AirlinesCompany;
using Airport.Facade.AirlinesCompany;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.AirlinesCompany
{
    [TestClass]
    public class AirlinesCompanyViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(AirlinesCompanyViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<AirlinesCompanyView>();
            var data = AirlinesCompanyViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<AirlinesCompanyData>();
            var view = AirlinesCompanyViewFactory.Create(new global::Airport.Domain.AirlinesCompany.AirlinesCompany());
            TestArePropertyValuesEqual(view, data);
        }
    }
}
