using System;
using Airport.Data.Airport;
using Airport.Infra;
using Airport.Infra.Airport;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.Airport
{
    [TestClass]
    public class AirportsRepositoryTests : RepositoryTests<AirportsRepository, global::Airport.Domain.Airport.Airport, AirportData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            DbSet = ((AirportDbContext)db).Airports;
            obj = new AirportsRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.Airport.Airport, AirportData>);

        protected override string GetId(AirportData d) => d.Id;

        protected override global::Airport.Domain.Airport.Airport GetObject(AirportData d) => new global::Airport.Domain.Airport.Airport(d);

        protected override void SetId(AirportData d, string id) => d.Id = id;
    }
}
