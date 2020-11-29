using System.Collections.Generic;
using Airport.Data.Api.ApiCity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiCity
{
    [TestClass]
    public class ApiCityDataTests : BaseClassTests<ApiCityData, object>
    {
        public List<ApiCityProperties> places = new List<ApiCityProperties>();

        [TestMethod]
        public void placesTest()
        {
            Assert.AreEqual(0, places.Count);
        }
    }
}
