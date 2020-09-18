using Airport.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.Common
{
    class UniqueEntityViewTests : AbstractClassTests<UniqueEntityView, UniqueEntityView>
    {
        private class TestClass : UniqueEntityView { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }

        [TestMethod]
        public void IdTest()
            => IsNullableProperty(() => obj.Id, x => obj.Id = x);
    }
}
