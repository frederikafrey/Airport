using Airport.Aids;
using Airport.Data.Airport;
using Airport.Domain.Airport;
using Airport.Facade.Airport;
using Airport.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Pages
{
    [TestClass]
    public class CommonPageTests
        : AbstractPageTests<CommonPage<IAirportsRepository, global::Airport.Domain.Airport.Airport, AirportView, AirportData>
            , PaginatedPage<IAirportsRepository, global::Airport.Domain.Airport.Airport, AirportView, AirportData>>
    {

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass(new TestRepository());
        }

        [TestMethod]
        public void ItemIdTest()
        {
            obj.Item = GetRandom.Object<AirportView>();
            Assert.AreEqual(obj.Item.Id, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest()
        {
            IsNullableProperty(() => obj.PageTitle, x => obj.PageTitle = x);
        }

        [TestMethod]
        public void PageSubTitleTest()
        {
            IsReadOnlyProperty(obj, nameof(obj.PageSubTitle), obj.GetPageSubTitle());
        }

        [TestMethod]
        public void GetPageSubTitleTest()
        {
            Assert.AreEqual(obj.PageSubTitle, obj.GetPageSubTitle());
        }

        [TestMethod]
        public void PageUrlTest()
        {
            IsReadOnlyProperty(obj, nameof(obj.PageUrl), obj.GetPageUrl());
        }

        [TestMethod]
        public void GetPageUrlTest()
        {
            Assert.AreEqual(obj.PageUrl, obj.GetPageUrl());
        }

        [TestMethod]
        public void IndexUrlTest()
        {
            IsReadOnlyProperty(obj, nameof(obj.IndexUrl), obj.GetIndexUrl());
        }

        [TestMethod]
        public void GetIndexUrlTest()
        {
            Assert.AreEqual(obj.IndexUrl, obj.GetIndexUrl());
        }
    }
}
