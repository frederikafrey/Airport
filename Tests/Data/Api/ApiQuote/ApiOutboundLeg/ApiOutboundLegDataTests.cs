using System.Collections.Generic;
using Airport.Data.Api.ApiQuote.ApiOutboundLeg;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiQuote.ApiOutboundLeg
{
    [TestClass]
    public class ApiOutboundLegDataTests : BaseClassTests<ApiOutboundLegData, object>
    {
        public List<ApiOutboundLegProperties> outboundLegs = new List<ApiOutboundLegProperties>();

        [TestMethod]
        public void outboundLegsTest()
        {
            Assert.AreEqual(0, outboundLegs.Count);
        }
    }
}
