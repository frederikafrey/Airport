using Airport.Aids;
using Airport.Data.AirlinesCompany;
using Airport.Data.Flight;
using Airport.Domain.AirlinesCompany;
using Airport.Domain.Flight;
using Airport.Facade.AirlinesCompany;
using Airport.Pages;
using Airport.Pages.AirlinesCompany;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.AirlinesCompany
{
    [TestClass]
    public class AirlinesCompaniesPageTests : AbstractClassTests
        <AirlinesCompaniesPage, CommonPage<IAirlinesCompaniesRepository, global::Airport.Domain.AirlinesCompany.AirlinesCompany, AirlinesCompanyView, AirlinesCompanyData>>
    {
        private class TestClass : AirlinesCompaniesPage
        {
            internal TestClass(IAirlinesCompaniesRepository r) : base(r) { }
        }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.AirlinesCompany.AirlinesCompany, AirlinesCompanyData>,
            IAirlinesCompaniesRepository { }

        private class TermRepository : BaseTestRepositoryForUniqueEntity<
            global::Airport.Domain.Flight.Flight, FlightData>, IFlightsRepository { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var r = new TestRepository();
            var t = new TermRepository();
            obj = new TestClass(r);
        }

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<AirlinesCompanyView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Airline Companies", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/AirlinesCompany/AirlinesCompanies", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<AirlinesCompanyView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<AirlinesCompanyData>();
            var view = obj.ToView(new global::Airport.Domain.AirlinesCompany.AirlinesCompany(data));
            TestArePropertyValuesEqual(view, data);
        }
    }
}
