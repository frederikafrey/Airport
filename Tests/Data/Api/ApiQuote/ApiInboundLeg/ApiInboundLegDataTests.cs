using System.Collections.Generic;
using Airport.Data.Api.ApiQuote.ApiInboundLeg;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiQuote.ApiInboundLeg
{
    [TestClass]
    public class ApiInboundLegDataTests : BaseClassTests<ApiInboundLegData, object>
    {
        public List<ApiInboundLegProperties> inboundLegs = new List<ApiInboundLegProperties>();

        [TestMethod]
        public void inboundLegsTest()
        {
            Assert.AreEqual(0, inboundLegs.Count);
        }
    }
}
