using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Airport.Aids;
using Airport.Data.Airport;
using Airport.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra
{
    [TestClass]
    public class SortedRepositoryTests : AbstractClassTests<SortedRepository<global::Airport.Domain.Airport.Airport, AirportData>, BaseRepository<global::Airport.Domain.Airport.Airport, AirportData>>
    {
        private class TestClass : SortedRepository<global::Airport.Domain.Airport.Airport, AirportData>
        {
            public TestClass(DbContext c, DbSet<AirportData> s) : base(c, s) { }

            protected override global::Airport.Domain.Airport.Airport ToDomainObject(AirportData d)
                => new global::Airport.Domain.Airport.Airport(d);

            protected override async Task<AirportData> GetData(string id)
            {
                await Task.CompletedTask;
                return new AirportData();
            }

            protected override string GetId(global::Airport.Domain.Airport.Airport entity) => entity?.Data?.Id;
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var options = new DbContextOptionsBuilder<AirportDbContext>().UseInMemoryDatabase("TestDb").Options;
            var c = new AirportDbContext(options);
            obj = new TestClass(c, c.Airports);
        }

        [TestMethod]
        public void SortOrderTest() => IsNullableProperty(() => obj.SortOrder, x => obj.SortOrder = x);

        [TestMethod]
        public void DescendingStringTest()
        {
            var propertyName = GetMember.Name<TestClass>(x => x.DescendingString);
            IsReadOnlyProperty(obj, propertyName, "_desc");
        }

        [TestMethod]
        public void SetSortingTest()
        {
            void Test(IQueryable<AirportData> d, string sortOrder)
            {
                obj.SortOrder = sortOrder + obj.DescendingString;
                var set = obj.AddSorting(d);
                Assert.IsNotNull(set);
                Assert.AreNotEqual(d, set);
                var str = set.Expression.ToString();
                Assert.IsTrue(str
                    .Contains($"AirportClub.Data.Airport.AirportData]).OrderByDescending(x => Convert(x.{sortOrder}, Object))"));
                obj.SortOrder = sortOrder;
                set = obj.AddSorting(d);
                Assert.IsNotNull(set);
                Assert.AreNotEqual(d, set);
                str = set.Expression.ToString();
                Assert.IsTrue(str.Contains($"Airport.Data.Airport.AirportData]).OrderBy(x => Convert(x.{sortOrder}, Object))"));
            }
            Assert.IsNull(obj.AddSorting(null));
            IQueryable<AirportData> data = obj.dbSet;
            obj.SortOrder = null;
            Assert.AreEqual(data, obj.AddSorting(data));
            Test(data, GetMember.Name<AirportData>(x => x.Id));
            Test(data, GetMember.Name<AirportData>(x => x.Address));
            Test(data, GetMember.Name<AirportData>(x => x.Phone));
        }

        [TestMethod]
        public void CreateExpressionTest()
        {
            string s;
            TestCreateExpression(GetMember.Name<AirportData>(x => x.Address));
            TestCreateExpression(GetMember.Name<AirportData>(x => x.Phone));
            TestCreateExpression(GetMember.Name<AirportData>(x => x.Id));
            TestCreateExpression(s = GetMember.Name<AirportData>(x => x.Address), s + obj.DescendingString);
            TestCreateExpression(s = GetMember.Name<AirportData>(x => x.Phone), s + obj.DescendingString);
            TestCreateExpression(s = GetMember.Name<AirportData>(x => x.Id), s + obj.DescendingString);
            TestNullExpression(GetRandom.String());
            TestNullExpression(string.Empty);
            TestNullExpression(null);
        }

        private void TestNullExpression(string name)
        {
            obj.SortOrder = name;
            var lambda = obj.CreateExpression();
            Assert.IsNull(lambda);
        }

        private void TestCreateExpression(string expected, string name = null)
        {
            name ??= expected;
            obj.SortOrder = name;
            var lambda = obj.CreateExpression();
            Assert.IsNotNull(lambda);
            Assert.IsInstanceOfType(lambda, typeof(Expression<Func<AirportData, object>>));
            Assert.IsTrue(lambda.ToString().Contains(expected));
        }

        [TestMethod]
        public void FindPropertyTest()
        {
            string s;
            void Test(PropertyInfo expected, string sortOrder)
            {
                obj.SortOrder = sortOrder;
                Assert.AreEqual(expected, obj.FindProperty());
            }
            Test(null, GetRandom.String());
            Test(null, null);
            Test(null, string.Empty);
            Test(typeof(AirportData).GetProperty(s = GetMember.Name<AirportData>(x => x.Address)), s);
            Test(typeof(AirportData).GetProperty(s = GetMember.Name<AirportData>(x => x.Phone)), s);
            Test(typeof(AirportData).GetProperty(s = GetMember.Name<AirportData>(x => x.Id)), s);
            Test(typeof(AirportData).GetProperty(s = GetMember.Name<AirportData>(x => x.Address)), s + obj.DescendingString);
            Test(typeof(AirportData).GetProperty(s = GetMember.Name<AirportData>(x => x.Phone)), s + obj.DescendingString);
            Test(typeof(AirportData).GetProperty(s = GetMember.Name<AirportData>(x => x.Id)), s + obj.DescendingString);
        }

        [TestMethod]
        public void GetNameTest()
        {
            string s;
            void Test(string expected, string sortOrder)
            {
                obj.SortOrder = sortOrder;
                Assert.AreEqual(expected, obj.GetName());
            }
            Test(s = GetRandom.String(), s);
            Test(s = GetRandom.String(), s + obj.DescendingString);
            Test(string.Empty, string.Empty);
            Test(string.Empty, null);
        }

        [TestMethod]
        public void SetOrderByTest()
        {
            void Test(IQueryable<AirportData> d, Expression<Func<AirportData, object>> e, string expected)
            {
                obj.SortOrder = GetRandom.String() + obj.DescendingString;
                var set = obj.AddOrderBy(d, e);
                Assert.IsNotNull(set);
                Assert.AreNotEqual(d, set);
                Assert.IsTrue(set.Expression.ToString()
                    .Contains($"Airport.Data.Airport.AirportData]).OrderByDescending({expected})"));
                obj.SortOrder = GetRandom.String();
                set = obj.AddOrderBy(d, e);
                Assert.IsNotNull(set);
                Assert.AreNotEqual(d, set);
                Assert.IsTrue(set.Expression.ToString().Contains($"Airport.Data.Airport.AirportData]).OrderBy({expected})"));
            }
            Assert.IsNull(obj.AddOrderBy(null, null));
            IQueryable<AirportData> data = obj.dbSet;
            Assert.AreEqual(data, obj.AddOrderBy(data, null));
            Test(data, x => x.Id, "x => x.Id");
            Test(data, x => x.Address, "x => x.Address");
            Test(data, x => x.Phone, "x => x.Phone");
        }

        [TestMethod]
        public void IsDescendingTest()
        {
            void Test(string sortOrder, bool expected)
            {
                obj.SortOrder = sortOrder;
                Assert.AreEqual(expected, obj.IsDescending());
            }
            Test(GetRandom.String(), false);
            Test(GetRandom.String() + obj.DescendingString, true);
            Test(string.Empty, false);
            Test(null, false);
        }
        [TestMethod]
        public void CreateSqlQueryTest()
        {
            var sql = obj.CreateSqlQuery();
            Assert.IsNotNull(sql);
        }

        [TestMethod]
        public void AddSortingTest()
        {
            var sql = obj.CreateSqlQuery();
            var searchString = GetRandom.String();
            obj.SortOrder = searchString;
            var sqlNew = obj.AddSorting(sql);
            Assert.IsNotNull(sqlNew);
        }
    }
}
