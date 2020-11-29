using Airport.Data.Api.ApiQuote.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiQuote.Common
{
    [TestClass]
    public class ApiLegPropertiesTests : BaseClassTests<ApiLegProperties, ApiQuoteProperties>
    {
        private class TestClass : ApiLegProperties { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }

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
