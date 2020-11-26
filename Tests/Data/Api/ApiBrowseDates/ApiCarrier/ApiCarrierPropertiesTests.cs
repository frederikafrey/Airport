using Airport.Data.Api.ApiBrowseDates.ApiCarrier;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiBrowseDates.ApiCarrier
{
    [TestClass]
    public class ApiCarrierPropertiesTests : SealedClassTests<ApiCarrierProperties, UniqueEntityData>
    {
        [TestMethod]
        public void CarrierIdTest() => IsProperty<int>();

        [TestMethod]
        public void NameTest() => IsNullableProperty(() => obj.Name, x => obj.Name = x);
    }
}
