using Airport.Data.Api.ApiCity;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiCity
{
    [TestClass]
    class ApiCityPropertiesTests : SealedClassTests<ApiCityProperties, UniqueEntityData>
    {
        [TestMethod]
        public void PlaceNameTest() => IsNullableProperty(() => obj.PlaceName, x => obj.PlaceName = x);

        [TestMethod]
        public void CountryNameTest() => IsNullableProperty(() => obj.CountryName, x => obj.CountryName = x);
    }
}
