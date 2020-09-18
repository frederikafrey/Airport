using Airport.Data.Airport;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Airport
{
    [TestClass]
    public class AirportDataTests : SealedClassTests<AirportData, UniqueEntityData>
    {
        [TestMethod]
        public void AddressTest() => IsNullableProperty(() => obj.Address, x => obj.Address = x);

        [TestMethod]
        public void PhoneTest() => IsNullableProperty(() => obj.Phone, x => obj.Phone = x);
    }
}
