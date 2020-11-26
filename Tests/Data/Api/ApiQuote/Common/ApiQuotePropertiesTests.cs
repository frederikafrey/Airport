using System;
using Airport.Data.Api.ApiBrowseDates.ApiQuote.Common;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Api.ApiBrowseDates.ApiQuote.Common
{
    [TestClass]
    public class ApiQuotePropertiesTests : SealedClassTests<ApiQuoteProperties, UniqueEntityData>
    {
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
