﻿//using Airport.Aids;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Tests.Aids {

//    [TestClass] public class CreateNewTests : BaseTests {

//        [TestInitialize] public void TestInitialize() => type = typeof(CreateNew);

//        [TestMethod] public void InstanceTest() 
//        {
//            var o1 = CreateNew.Instance<TestClass1>();
//            var o2 = CreateNew.Instance<TestClass1>();
//            Assert.IsInstanceOfType(o1, typeof(TestClass1));
//            Assert.AreNotEqual(o1.S, o2.S);
//            Assert.AreNotEqual(o1.I, o2.I);
//        }

//        [TestMethod] public void CreateDefaultTest() 
//        {
//            var o1 = CreateNew.Instance<TestClass2>();
//            var o2 = CreateNew.Instance<TestClass2>();
//            Assert.IsInstanceOfType(o1, typeof(TestClass2));
//            Assert.AreNotEqual(o1.S, o2.S);
//            Assert.AreNotEqual(o1.I, o2.I);
//        }

//        [TestMethod] public void CreateStringTest() 
//        {
//            var s = CreateNew.Instance<string>();
//            Assert.IsInstanceOfType(s, typeof(string));
//        }

//        [TestMethod] public void CantCreateStaticTest() { }

//        private class TestClass1 
//        {
//            public TestClass1(int i, string s) {
//                S = s;
//                I = i;
//            }
//            public int I { get; }
//            public string S { get; }
//        }

//        private class TestClass2 
//        {
//            public int I { get; } = GetRandom.Int32();
//            public string S { get; } = GetRandom.String();
//        }
//    }
//}