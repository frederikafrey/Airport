using System.Collections.Generic;
using Airport.Domain.Api.ApiQuote.ApiInboundLeg;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.Api.ApiQuote.ApiInboundLeg
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
