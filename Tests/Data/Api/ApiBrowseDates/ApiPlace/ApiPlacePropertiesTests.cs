using Airport.Data.Api.ApiBrowseDates.ApiPlace;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiBrowseDates.ApiPlace
{
    [TestClass]
    public class ApiPlacePropertiesTests : SealedClassTests<ApiPlaceProperties, UniqueEntityData>
    {
        [TestMethod]
        public void PlaceIdTest() => IsProperty<int>();
        [TestMethod]
        public void NameTest() => IsNullableProperty(() => obj.Name, x => obj.Name = x);
        [TestMethod]
        public void CityNameTest() => IsNullableProperty(() => obj.CityName, x => obj.CityName = x);
        [TestMethod]
        public void CountryNameTest() => IsNullableProperty(() => obj.CountryName, x => obj.CountryName = x);
    }
}
