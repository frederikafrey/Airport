using System.Collections.Generic;
using Airport.Data.Api.ApiCurrency;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiCurrency
{
    [TestClass]
    public class ApiCurrencyDataTests : BaseClassTests<ApiCurrencyData, object>
    {
        public List<ApiCurrencyProperties> currencies = new List<ApiCurrencyProperties>();

        [TestMethod]
        public void currenciesTest()
        {
            Assert.AreEqual(0, currencies.Count);
        }
    }
}
