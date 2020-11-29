using Airport.Data.Api.ApiCity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiCity
{
    [TestClass]
    class ApiCityPropertiesTests : BaseClassTests<ApiCityProperties, object>
    {
        private class TestClass : ApiCityProperties { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }
        [TestMethod]
        public void PlaceNameTest() => IsNullableProperty(() => obj.PlaceName, x => obj.PlaceName = x);

        [TestMethod]
        public void CountryNameTest() => IsNullableProperty(() => obj.CountryName, x => obj.CountryName = x);
    }
}
