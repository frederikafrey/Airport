using Airport.Data.AirlinesCompany;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.AirlinesCompany
{
    [TestClass]
    public class AirlinesCompanyDataTests : SealedClassTests<AirlinesCompanyData, UniqueEntityData>
    {
        [TestMethod]
        public void NameTest() => IsNullableProperty(() => obj.Name, x => obj.Name = x);

        [TestMethod]
        public void AddressTest() => IsNullableProperty(() => obj.Address, x => obj.Address = x);
    }
}
