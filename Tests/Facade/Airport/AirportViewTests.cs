using Airport.Facade.Airport;
using Airport.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.Airport
{
    [TestClass]
    public class AirportViewTests : SealedClassTests<AirportView, UniqueEntityView>
    {
        [TestMethod]
        public void AddressTest() => IsNullableProperty(() => obj.Address, x => obj.Address = x);

        [TestMethod]
        public void PhoneTest() => IsNullableProperty(() => obj.Phone, x => obj.Phone = x);
    }
}
