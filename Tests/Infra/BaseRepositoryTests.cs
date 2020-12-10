using System.Threading.Tasks;
using Airport.Aids;
using Airport.Data.Airport;
using Airport.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra
{
    [TestClass]
    public class BaseRepositoryTests : AbstractClassTests<BaseRepository<global::Airport.Domain.Airport.Airport, AirportData>, object>
    {
        private AirportData data;

        private class TestClass : BaseRepository<global::Airport.Domain.Airport.Airport, AirportData>
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
            data = GetRandom.Object<AirportData>();
        }

        [TestMethod]
        public void GetTest()
        {
            var count = GetRandom.UInt8(15, 30);
            var countBefore = obj.Get().GetAwaiter().GetResult().Count;
            for (var i = 0; i < count; i++)
            {
                data = GetRandom.Object<AirportData>();
                AddTest();
            }
            Assert.AreEqual(count + countBefore, obj.Get().GetAwaiter().GetResult().Count);
        }

        [TestMethod]
        public void GetByIdTest() => AddTest();

        [TestMethod]
        public void DeleteTest()
        {
            AddTest();
            var expected = obj.Get(data.Id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(data, expected.Data);
            obj.Delete(data.Id).GetAwaiter();
            expected = obj.Get(data.Id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);
        }

        [TestMethod]
        public virtual void AddTest()
        {
            var expected = obj.Get(data.Id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);
            obj.Add(new global:: Airport.Domain.Airport.Airport(data)).GetAwaiter();
            expected = obj.Get(data.Id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(data, expected.Data);
        }

        [TestMethod]
        public void UpdateTest()
        {
            AddTest();
            var newData = GetRandom.Object<AirportData>();
            newData.Id = data.Id;
            obj.Update(new global::Airport.Domain.Airport.Airport(newData)).GetAwaiter();
            var expected = obj.Get(data.Id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(newData, expected.Data);
        }
        [TestMethod]
        public void CreateSqlQueryTest()
        {
            var sql = obj.CreateSqlQuery();
            Assert.IsNotNull(sql);
        }

        [TestMethod]
        public void DbSetTest() { Assert.Inconclusive();}
    }
}
