using Airport.Aids;
using Airport.Data.AirlineCompany;
using Airport.Facade.AirlineCompany;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.AirlineCompany
{
    [TestClass]
    public class AirlineCompanyViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(AirlineCompanyViewFactory);

        [TestMethod]
        public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<AirlineCompanyView>();
            var data = AirlineCompanyViewFactory.Create(view).Data;
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<AirlineCompanyData>();
            var view = AirlineCompanyViewFactory.Create(new global::Airport.Domain.AirlineCompany.AirlineCompany(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
