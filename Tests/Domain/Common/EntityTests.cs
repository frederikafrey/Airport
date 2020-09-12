
//using Airport.Aids;
//using Domain.Common;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Tests.Domain.Common
//{
//    [TestClass]
//    public class EntityTests : AbstractClassTests<Entity<TrainingData>, object>
//    {
//        private class TestClass : Entity<TrainingData>
//        {
//            public TestClass(TrainingData d = null) : base(d) { }
//        }

//        [TestInitialize]
//        public override void TestInitialize()
//        {
//            base.TestInitialize();
//            obj = new TestClass();
//        }

//        [TestMethod]
//        public void DataTest()
//        {
//            var d = GetRandom.Object<TrainingData>();
//            Assert.AreNotSame(d, obj.Data);
//            obj = new TestClass(d);
//            Assert.AreSame(d, obj.Data);
//        }

//        [TestMethod]
//        public void DataIsNullTest()
//        {
//            var d = GetRandom.Object<TrainingData>();
//            Assert.IsNull(obj.Data);
//            obj.Data = d;
//            Assert.AreSame(d, obj.Data);
//        }

//        [TestMethod]
//        public void CanSetNullDataTest()
//        {
//            obj.Data = null;
//            Assert.IsNull(obj.Data);
//        }
//    }
//}
