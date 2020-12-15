using System;
using System.Collections.Generic;
using System.Reflection;
using Airport.Aids;
using Airport.Data.FlightOfPassenger;
using Airport.Facade.Flight;
using Airport.Facade.FlightOfPassenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Aids
{

    [TestClass]
    public class GetClassTests : BaseTests
    {
        [TestInitialize] public void TestInitialize() => type = typeof(GetClass);

        [TestMethod]
        public void NamespaceTest()
        {
            var t = typeof(object);
            Assert.AreEqual(t.Namespace, GetClass.Namespace(t));
            Assert.AreEqual(string.Empty, GetClass.Namespace(null));
        }

        [TestMethod]
        public void MembersTest()
        {
            var x = GetRandom.Object<FlightOfPassengerData>();
            var y = GetRandom.Object<FlightOfPassengerView>();
            TestArePropertyValuesNotEqual(x, y);
            Copy.Members(x, y);
            TestArePropertyValuesEqual(x, y);
        }

        private static void TestNull(Type t)
        {
            var a = GetClass.Members(t);
            Assert.IsInstanceOfType(a, typeof(List<MemberInfo>));
            Assert.AreEqual(0, a.Count);
        }

        [TestMethod]
        public void PropertiesTest()
        {
            var a = GetClass.Properties(typeof(TestClass));
            Assert.IsNotNull(a);
            Assert.IsInstanceOfType(a, typeof(List<PropertyInfo>));
            Assert.AreEqual(1, a.Count);
            Assert.AreEqual("F", a[0].Name);
        }

        [TestMethod]
        public void ReadWritePropertyValuesTest()
        {
            var o = GetRandom.Object<TestClass>();
            var l = GetClass.ReadWritePropertyValues(o);
            Assert.AreEqual(1, l.Count);
            Assert.AreEqual(l[0], o.F);
        }

        [TestMethod]
        public void PropertyTest()
        {
            static void Test(string name)
                => Assert.AreEqual(name, GetClass.Property<FlightView>(name).Name);

            Assert.IsNull(GetClass.Property<FlightView>((string)null));
            Assert.IsNull(GetClass.Property<FlightView>(string.Empty));
            Assert.IsNull(GetClass.Property<FlightView>("bla bla"));
            //Test(GetMember.Name<FlightView>(m => m.Name));
        }

        internal class TestBaseClass
        {
            public void Aaa() => bbb();
            private void bbb() { }
            public static void Ccc() => ddd();
            private static void ddd() { }
        }

        internal class TestClass : TestBaseClass
        {
            public int E = 0;
            public string F { get; set; }
        }
    }
}
