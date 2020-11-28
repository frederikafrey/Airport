using Airport.Data.Api.ApiQuote.ApiInboundLeg;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiQuote.ApiInboundLeg
{
    [TestClass]
    public class ApiInboundLegPropertiesTests : AbstractClassTests<ApiInboundLegProperties, object>
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
