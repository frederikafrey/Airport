using Airport.Domain.Api.ApiQuote.ApiOutboundLeg;
using Airport.Domain.Api.ApiQuote.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.Api.ApiQuote.ApiOutboundLeg
{
    [TestClass]
    public class ApiOutboundLegPropertiesTests : BaseClassTests<ApiOutboundLegProperties, ApiLegProperties>
    {
        private class TestClass : ApiOutboundLegProperties { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }
    }
}
