using System.Collections.Generic;
using Airport.Data.Api.ApiCarrier;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiCarrier
{
    [TestClass]
    public class ApiCarrierDataTests : BaseClassTests<ApiCarrierData, object>
    {
        public List<ApiCarrierProperties> carriers = new List<ApiCarrierProperties>();

        [TestMethod]
        public void carriersTest()
        {
            Assert.AreEqual(0, carriers.Count);
        }
    }
}
