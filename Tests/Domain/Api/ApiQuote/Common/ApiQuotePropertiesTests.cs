using System;
using Airport.Domain.Api.ApiQuote.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.Api.ApiQuote.Common
{
    [TestClass]
    public class ApiQuotePropertiesTests : BaseClassTests<ApiQuoteProperties, object>
    {
        private class TestClass : ApiQuoteProperties { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }

        [TestMethod]
        public void DirectTest() => IsProperty<bool>();

        [TestMethod]
        public void MinPriceTest() => IsProperty<double>();

        [TestMethod]
        public void QuoteIdTest() => IsProperty<int>();

        [TestMethod]
        public void ArrivalDateTest() => IsProperty<DateTime>();

        [TestMethod]
        public void DepartureDateTest() => IsProperty<DateTime>();
    }
}
