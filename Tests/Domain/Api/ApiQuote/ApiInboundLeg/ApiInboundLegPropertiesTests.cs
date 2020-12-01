using Airport.Domain.Api.ApiQuote.ApiInboundLeg;
using Airport.Domain.Api.ApiQuote.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.Api.ApiQuote.ApiInboundLeg
{
    [TestClass]
    public class ApiInboundLegPropertiesTests : BaseClassTests<ApiInboundLegProperties, ApiLegProperties>
    {
        private class TestClass : ApiInboundLegProperties { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }
    }
}
