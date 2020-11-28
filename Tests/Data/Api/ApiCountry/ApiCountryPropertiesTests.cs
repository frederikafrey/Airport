using Airport.Data.Api.ApiCountry;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiCountry
{
    [TestClass]
    public class ApiCountryPropertiesTests : AbstractClassTests<ApiCountryProperties, object>
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
    }
}
