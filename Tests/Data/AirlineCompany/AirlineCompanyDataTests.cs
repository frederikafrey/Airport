using Airport.Data.AirlineCompany;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.AirlineCompany
{
    [TestClass]
    public class AirlineCompanyDataTests : SealedClassTests<AirlineCompanyData, UniqueEntityData>
    {
        [TestMethod]
        public void NameTest() => IsNullableProperty(() => obj.Name, x => obj.Name = x);

        [TestMethod]
        public void AddressTest() => IsNullableProperty(() => obj.Address, x => obj.Address = x);
    }
}
