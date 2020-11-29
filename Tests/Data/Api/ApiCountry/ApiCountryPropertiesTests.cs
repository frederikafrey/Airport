using Airport.Data.Api.ApiCountry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiCountry
{
    [TestClass]
    public class ApiCountryPropertiesTests : BaseClassTests<ApiCountryProperties, object>
    {
        private class TestClass : ApiCountryProperties { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }
        [TestMethod]
        public void NameTest() => IsNullableProperty(() => obj.Name, x => obj.Name = x);

        [TestMethod]
        public void CodeTest() => IsNullableProperty(() => obj.Code, x => obj.Code = x);
    }
}
