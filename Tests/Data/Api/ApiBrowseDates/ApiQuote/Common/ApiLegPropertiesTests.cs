using Airport.Data.Api.ApiBrowseDates.ApiQuote.Common;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiBrowseDates.ApiQuote.Common
{
    [TestClass]
    public class ApiLegPropertiesTests : SealedClassTests<ApiLegProperties, UniqueEntityData>
    {
        [TestMethod]
        public void CarrierIdsTest() => IsProperty<int>();

        [TestMethod]
        public void DepartureDateTest() => IsNullableProperty(() => obj.DepartureDate, x => obj.DepartureDate = x);

        [TestMethod]
        public void DestinationIdTest() => IsProperty<int>();

        [TestMethod]
        public void OriginIdTest() => IsProperty<int>();
    }
}
