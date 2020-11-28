using Airport.Data.Api.ApiCurrency;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiCurrency
{
    [TestClass]
    public class ApiCurrencyPropertiesTests : AbstractClassTests<ApiCurrencyProperties, object>
    {
        private class TestClass : ApiCurrencyProperties { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }
        [TestMethod]
        public void CodeTest() => IsNullableProperty(() => obj.Code, x => obj.Code = x);

        [TestMethod]
        public void SymbolTest() => IsNullableProperty(() => obj.Symbol, x => obj.Symbol = x);

        [TestMethod]
        public void ThousandsSeparatorTest() => IsNullableProperty(() => obj.ThousandsSeparator, x => obj.ThousandsSeparator = x);

        [TestMethod]
        public void DecimalSeparatorTest() => IsNullableProperty(() => obj.DecimalSeparator, x => obj.DecimalSeparator = x);

        [TestMethod]
        public void SymbolOnLeftTest() => IsProperty<bool>();

        [TestMethod]
        public void SpaceBetweenAmountAndSymbolTest() => IsProperty<bool>();

        [TestMethod]
        public void RoundingCoefficientTest() => IsProperty<int>();

        [TestMethod]
        public void DecimalDigitsTest() => IsProperty<int>();
    }
}
