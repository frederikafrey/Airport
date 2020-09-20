using System;
using Airport.Data.AirlinesCompany;
using Airport.Infra;
using Airport.Infra.AirlinesCompany;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra.AirlinesCompany
{
    [TestClass]
    public class AirlinesCompaniesRepositoryTests : RepositoryTests<AirlinesCompaniesRepository, global::Airport.Domain.AirlinesCompany.AirlinesCompany, AirlinesCompanyData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<AirportDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new AirportDbContext(options);
            dbSet = ((AirportDbContext)db).AirlinesCompanies;
            obj = new AirlinesCompaniesRepository((AirportDbContext)db);
            base.TestInitialize();
        }

        protected override Type GetBaseType() => typeof(UniqueEntityRepository<global::Airport.Domain.AirlinesCompany.AirlinesCompany, AirlinesCompanyData>);

        protected override string GetId(AirlinesCompanyData d) => d.Id;

        protected override global::Airport.Domain.AirlinesCompany.AirlinesCompany GetObject(AirlinesCompanyData d) => new global::Airport.Domain.AirlinesCompany.AirlinesCompany(d);

        protected override void SetId(AirlinesCompanyData d, string id) => d.Id = id;
    }
}
