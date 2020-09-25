using Airport.Facade.AirlineCompany;
using Airport.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.AirlineCompany
{
    [TestClass]
    public class AirlineCompanyViewTests : SealedClassTests<AirlineCompanyView, UniqueEntityView>
    {
        [TestMethod]
        public void NameTest() => IsNullableProperty(() => obj.Name, x => obj.Name = x);

        [TestMethod]
        public void AddressTest() => IsNullableProperty(() => obj.Address, x => obj.Address = x);
    }
}
