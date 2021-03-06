﻿using Airport.Domain.Api.ApiCarrier;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.Api.ApiCarrier
{
    [TestClass]
    public class ApiCarrierPropertiesTests : BaseClassTests<ApiCarrierProperties, object>
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
