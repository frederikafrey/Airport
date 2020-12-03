using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra
{
    public class DbInitializerTests<TDbContext> : BaseTests
        where TDbContext : DbContext
    {
        protected TDbContext db;
        protected DbContextOptions<TDbContext> options;

        [TestInitialize]
        public virtual void TestInitialize()
        {
            options = new DbContextOptionsBuilder<TDbContext>().UseInMemoryDatabase("TestDb").Options;
        }
        protected void RemoveAll<TData>(DbSet<TData> db) where TData : class, new() => RemoveAll(db);
    }
}
