using System.Threading.Tasks;
using Airport.Aids;
using Airport.Data.Airport;
using Airport.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra
{
    [TestClass]
    public class FilteredRepositoryTests : AbstractClassTests<FilteredRepository<global::Airport.Domain.Airport.Airport, AirportData>,
        SortedRepository<global::Airport.Domain.Airport.Airport, AirportData>>
    {
        private class TestClass : FilteredRepository<global::Airport.Domain.Airport.Airport, AirportData>
        {
            public TestClass(DbContext c, DbSet<AirportData> s) : base(c, s) { }

            protected override global::Airport.Domain.Airport.Airport ToDomainObject(AirportData d)
                => new global::Airport.Domain.Airport.Airport(d);

            protected override async Task<AirportData> GetData(string id)
                => await DbSet.FirstOrDefaultAsync(m => m.Id == id);

            protected override string GetId(global::Airport.Domain.Airport.Airport entity) => entity?.Data?.Id;

        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            var c = new AirportDbContext(options);
            obj = new TestClass(c, c.Airports);
        }

        [TestMethod]
        public void SearchStringTest()
            => IsNullableProperty(() => obj.SearchString, x => obj.SearchString = x);

        [TestMethod]
        public void FixedFilterTest()
            => IsNullableProperty(() => obj.FixedFilter, x => obj.FixedFilter = x);

        [TestMethod]
        public void FixedValueTest()
            => IsNullableProperty(() => obj.FixedValue, x => obj.FixedValue = x);

        [TestMethod]
        public void CreateSqlQueryTest()
        {
            var sql = obj.CreateSqlQuery();
            Assert.IsNotNull(sql);
        }

        [TestMethod]
        public void AddFixedFilteringTest()
        {
            var sql = obj.CreateSqlQuery();
            var fixedFilter = GetMember.Name<AirportData>(x => x.Address);
            obj.FixedFilter = fixedFilter;
            var fixedValue = GetRandom.String();
            obj.FixedValue = fixedValue;
            var sqlNew = obj.AddFixedFiltering(sql);
            Assert.IsNotNull(sqlNew);
        }

        [TestMethod]
        public void CreateFixedWhereExpressionTest()
        {
            var properties = typeof(AirportData).GetProperties();
            var idx = GetRandom.Int32(0, properties.Length);
            var p = properties[idx];
            obj.FixedFilter = p.Name;
            var fixedValue = GetRandom.String();
            obj.FixedValue = fixedValue;
            var e = obj.CreateFixedWhereExpression();
            Assert.IsNotNull(e);
            var s = e.ToString();

            var expected = p.Name;
            if (p.PropertyType != typeof(string))
                expected += ".ToString()";
            expected += $" == \"{fixedValue}\"";
            Assert.IsTrue(s.Contains(expected));
        }

        [TestMethod]
        public void CreateFixedWhereExpressionOnFixedFilterNullTest()
        {
            Assert.IsNull(obj.CreateFixedWhereExpression());
            obj.FixedValue = GetRandom.String();
            obj.FixedFilter = GetRandom.String();
            Assert.IsNull(obj.CreateFixedWhereExpression());
        }

        [TestMethod]
        public void AddFilteringTest()
        {
            var sql = obj.CreateSqlQuery();
            var searchString = GetRandom.String();
            obj.SearchString = searchString;
            var sqlNew = obj.AddFiltering(sql);
            Assert.IsNotNull(sqlNew);
        }

        [TestMethod]
        public void CreateWhereExpressionTest()
        {
            var searchString = GetRandom.String();
            obj.SearchString = searchString;
            var e = obj.CreateWhereExpression();
            Assert.IsNotNull(e);
            var s = e.ToString();

            foreach (var p in typeof(AirportData).GetProperties())
            {
                var expected = p.Name;
                if (p.PropertyType != typeof(string))
                    expected += ".ToString()";
                expected += $".Contains(\"{searchString}\")";
                Assert.IsTrue(s.Contains(expected));
            }
        }

        [TestMethod]
        public void CreateWhereExpressionWithNullSearchStringTest()
        {
            obj.SearchString = null;
            var e = obj.CreateWhereExpression();
            Assert.IsNull(e);
        }
    }
}
