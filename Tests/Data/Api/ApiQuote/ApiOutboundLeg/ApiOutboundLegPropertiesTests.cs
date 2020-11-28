using Airport.Data.Api.ApiQuote.ApiOutboundLeg;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiQuote.ApiOutboundLeg
{
    [TestClass]
    public class ApiOutboundLegPropertiesTests : AbstractClassTests<ApiOutboundLegProperties, object>
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
