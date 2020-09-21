using Airport.Facade.AirlinesCompany;
using Airport.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.AirlinesCompany
{
    [TestClass]
    public class AirlinesCompanyViewTests : SealedClassTests<AirlinesCompanyView, UniqueEntityView>
    {
        [TestMethod]
        public void NameTest() => IsNullableProperty(() => obj.Name, x => obj.Name = x);

        [TestMethod]
        public void AddressTest() => IsNullableProperty(() => obj.Address, x => obj.Address = x);
    }
}
