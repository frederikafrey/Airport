using Airport.Data.Api.ApiQuote.ApiOutboundLeg;
using Airport.Data.Api.ApiQuote.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiQuote.ApiOutboundLeg
{
    [TestClass]
    public class ApiOutboundLegPropertiesTests : AbstractClassTests<ApiOutboundLegProperties, ApiLegProperties>
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
