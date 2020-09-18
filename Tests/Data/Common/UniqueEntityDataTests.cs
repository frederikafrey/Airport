﻿using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Common
{
    [TestClass]
    public class UniqueEntityDataTests : AbstractClassTests<UniqueEntityData, object>
    {
        private class TestClass : UniqueEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }

        [TestMethod]
        public void IdTest() => IsNullableProperty(() => obj.Id, x => obj.Id = x);
    }
}
