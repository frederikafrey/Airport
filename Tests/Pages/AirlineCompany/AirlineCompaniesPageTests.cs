using Airport.Aids;
using Airport.Data.AirlineCompany;
using Airport.Domain.AirlineCompany;
using Airport.Facade.AirlineCompany;
using Airport.Pages;
using Airport.Pages.AirlineCompany;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages.AirlineCompany
{
    [TestClass]
    public class AirlineCompaniesPageTests : AbstractClassTests
        <AirlineCompaniesPage, CommonPage<IAirlineCompaniesRepository, global::Airport.Domain.AirlineCompany.AirlineCompany, AirlineCompanyView, AirlineCompanyData>>
    {
        private class TestClass : AirlineCompaniesPage
        {
            internal TestClass(IAirlineCompaniesRepository r) : base(r) { }
        }

        private class TestRepository : BaseTestRepositoryForUniqueEntity<global::Airport.Domain.AirlineCompany.AirlineCompany, AirlineCompanyData>,
            IAirlineCompaniesRepository { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var r = new TestRepository();
            obj = new TestClass(r);
        }

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<AirlineCompanyView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Airline Companies", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/AirlineCompany/AirlineCompanies", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<AirlineCompanyView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<AirlineCompanyData>();
            var view = obj.ToView(new global::Airport.Domain.AirlineCompany.AirlineCompany(data));
            TestArePropertyValuesEqual(view, data);
        }

        [TestMethod]
        public void GetPageSubTitleTest() => Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());
    }
}
