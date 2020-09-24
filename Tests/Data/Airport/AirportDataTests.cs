using Airport.Data.Airport;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Airport
{
    [TestClass]
    public class AirportDataTests : SealedClassTests<AirportData, UniqueEntityData>
    {
        [TestMethod]
        public void CountryTest() => IsNullableProperty(() => obj.Country, x => obj.Country = x);

        [TestMethod]
        public void PhoneTest() => IsNullableProperty(() => obj.Phone, x => obj.Phone = x);
    }
}
