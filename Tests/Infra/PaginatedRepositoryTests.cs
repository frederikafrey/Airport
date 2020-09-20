using System;
using System.Threading.Tasks;
using Airport.Aids;
using Airport.Data.Airport;
using Airport.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra
{
    [TestClass]
    public class PaginatedRepositoryTests : AbstractClassTests<PaginatedRepository<global::Airport.Domain.Airport.Airport, AirportData>,
        FilteredRepository<global::Airport.Domain.Airport.Airport, AirportData>>
    {
        private class TestClass : PaginatedRepository<global::Airport.Domain.Airport.Airport, AirportData>
        {
            public TestClass(DbContext c, DbSet<AirportData> s) : base(c, s) { }

            protected override global::Airport.Domain.Airport.Airport ToDomainObject(AirportData d)
                => new global::Airport.Domain.Airport.Airport(d);

            protected override async Task<AirportData> GetData(string id)
                => await dbSet.FirstOrDefaultAsync(m => m.Id == id);

            protected override string GetId(global::Airport.Domain.Airport.Airport entity) => entity?.Data?.Id;
        }

        private byte count;

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();

            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            var c = new AirportDbContext(options);
            obj = new TestClass(c, c.Airports);
            count = GetRandom.UInt8(20, 40);
            foreach (var p in c.Airports)
                c.Entry(p).State = EntityState.Deleted;
            AddItems();
        }

        [TestMethod]
        public void PageIndexTest() => IsProperty(() => obj.PageIndex, x => obj.PageIndex = x);

        [TestMethod]
        public void TotalPagesTest()
        {
            var expected = (int)Math.Ceiling(count / (double)obj.PageSize);
            var totalPagesCount = obj.TotalPages;
            Assert.AreEqual(expected, totalPagesCount);
        }

        [TestMethod]
        public void HasNextPageTest()
        {
            void TestNextPage(int pageIndex, bool expected)
            {
                obj.PageIndex = pageIndex;
                var actual = obj.HasNextPage;
                Assert.AreEqual(expected, actual);
            }
            TestNextPage(0, true);
            TestNextPage(1, true);
            TestNextPage(GetRandom.Int32(2, obj.TotalPages - 1), true);
            TestNextPage(obj.TotalPages, false);
        }

        [TestMethod]
        public void HasPreviousPageTest()
        {
            void TestPreviousPage(int pageIndex, bool expected)
            {
                obj.PageIndex = pageIndex;
                var actual = obj.HasPreviousPage;
                Assert.AreEqual(expected, actual);
            }
            TestPreviousPage(0, false);
            TestPreviousPage(1, false);
            TestPreviousPage(2, true);
            TestPreviousPage(GetRandom.Int32(2, obj.TotalPages), true);
            TestPreviousPage(obj.TotalPages, true);
        }

        [TestMethod]
        public void PageSizeTest()
        {
            Assert.AreEqual(5, obj.PageSize);
            IsProperty(() => obj.PageSize, x => obj.PageSize = x);
        }

        [TestMethod]
        public void GetTotalPagesTest()
        {
            var expected = (int)Math.Ceiling(count / (double)obj.PageSize);
            var totalPagesCount = obj.GetTotalPages(obj.PageSize);
            Assert.AreEqual(expected, totalPagesCount);
        }

        [TestMethod]
        public void CountTotalPagesTest()
        {
            var expected = (int)Math.Ceiling(count / (double)obj.PageSize);
            var totalPagesCount = obj.CountTotalPages(count, obj.PageSize);
            Assert.AreEqual(expected, totalPagesCount);
        }

        [TestMethod]
        public void GetItemsCountTest()
        {
            var itemsCount = obj.GetItemsCount();
            Assert.AreEqual(count, itemsCount);
        }

        private void AddItems()
        {
            for (var i = 0; i < count; i++)
                obj.Add(new global::Airport.Domain.Airport.Airport(GetRandom.Object<AirportData>())).GetAwaiter();
        }

        [TestMethod]
        public void CreateSqlQueryTest()
        {
            var o = obj.CreateSqlQuery();
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void AddSkipAndTakeTest()
        {
            var sql = obj.CreateSqlQuery();
            var o = obj.AddSkipAndTake(sql);
            Assert.IsNotNull(o);
        }
    }
}
