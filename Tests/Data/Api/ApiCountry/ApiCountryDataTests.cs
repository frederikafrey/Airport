using System.Collections.Generic;
using Airport.Data.Api.ApiCountry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiCountry
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
