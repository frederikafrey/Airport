using System.Collections.Generic;
using Airport.Domain.Api.ApiCountry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.Api.ApiCountry
{
    [TestClass]
    public class ApiCountryDataTests : BaseClassTests<ApiCountryData, object>
    {
        public List<ApiCountryProperties> countries = new List<ApiCountryProperties>();

        [TestMethod]
        public void countriesTest()
        {
            Assert.AreEqual(0, countries.Count);
        }
    }
}
