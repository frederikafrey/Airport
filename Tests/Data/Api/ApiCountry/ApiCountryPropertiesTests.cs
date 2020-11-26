using Airport.Data.Api.ApiCountry;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiCountry
{
    [TestClass]
    public class ApiCountryPropertiesTests : SealedClassTests<ApiCountryProperties, UniqueEntityData>
    {
        [TestMethod]
        public void NameTest() => IsNullableProperty(() => obj.Name, x => obj.Name = x);
    }
}
