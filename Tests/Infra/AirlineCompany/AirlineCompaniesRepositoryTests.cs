using System;
using Airport.Data.AirlineCompany;
using Airport.Infra;
using Airport.Infra.AirlineCompany;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.AirlineCompany
{
    [TestClass]
    public class AirlineCompaniesRepositoryTests : RepositoryTests<AirlineCompaniesRepository, global::Airport.Domain.AirlineCompany.AirlineCompany, AirlineCompanyData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            DbSet = ((AirportDbContext)db).AirlinesCompanies;
            obj = new AirlineCompaniesRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.AirlineCompany.AirlineCompany, AirlineCompanyData>);

        protected override string GetId(AirlineCompanyData d) => d.Id;

        protected override global::Airport.Domain.AirlineCompany.AirlineCompany GetObject(AirlineCompanyData d) => new global::Airport.Domain.AirlineCompany.AirlineCompany(d);

        protected override void SetId(AirlineCompanyData d, string id) => d.Id = id;
    }
}
