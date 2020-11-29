using Airport.Data.Api.ApiCarrier;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiCarrier
{
    [TestClass]
    public class ApiCarrierPropertiesTests : AbstractClassTests<ApiCarrierProperties, object>
    {
        private class TestClass : ApiCarrierProperties { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }

        [TestMethod]
        public void CarrierIdTest() => IsProperty<int>();

        [TestMethod]
        public void NameTest() => IsNullableProperty(() => obj.Name, x => obj.Name = x);
    }
}
