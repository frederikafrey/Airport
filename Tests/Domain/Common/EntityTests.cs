using Airport.Aids;
using Airport.Data.Passenger;
using Airport.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.Common
{
    [TestClass]
    public class EntityTests : AbstractClassTests<Entity<PassengerData>, object>
    {
        private class TestClass : Entity<PassengerData>
        {
            public TestClass(PassengerData d = null) : base(d) { }
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }

        [TestMethod]
        public void DataTest()
        {
            var d = GetRandom.Object<PassengerData>();
            Assert.AreNotSame(d, obj.Data);
            obj = new TestClass(d);
            Assert.AreSame(d, obj.Data);
        }

        [TestMethod]
        public void DataIsNullTest()
        {
            var d = GetRandom.Object<PassengerData>();
            Assert.IsNull(obj.Data);
            obj.Data = d;
            Assert.AreSame(d, obj.Data);
        }

        [TestMethod]
        public void CanSetNullDataTest()
        {
            obj.Data = null;
            Assert.IsNull(obj.Data);
        }
    }
}
