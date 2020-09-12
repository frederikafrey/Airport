//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Airport.Aids;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Tests
//{
//    public class BaseTests
//    {
//        private static string notTested = "<{0}> is not tested";
//        private static string notSpecified = "Class in not specified";
//        private List<string> members { get; set; }
//        protected Type type;

//        [TestMethod]
//        public void IsTested()
//        {
//            if (type == null) Assert.Inconclusive(notSpecified);
//            var m = GetClass.Members(type, PublicBindingFlagsFor.DeclaredMembers);
//            members = m.Select(e => e.Name).ToList();
//            RemoveTested();

//            if (members.Count != 0) Assert.Fail(notTested, members[0]);
//        }

//        private void RemoveTested()
//        {
//            var tests = GetType().GetMembers().Select(e => e.Name).ToList();

//            for (var i = members.Count; i > 0; i--)
//            {
//                var m = members[i - 1] + "Test";
//                var isTested = tests.Find(o => o == m);

//                if (!string.IsNullOrEmpty(isTested)) members.RemoveAt(i - 1);
//            }
//        }
//        protected static void TestArePropertyValuesEqual(object obj1, object obj2)
//        {
//            foreach (var property in obj1.GetType().GetProperties())
//            {
//                var name = property.Name;
//                var p = obj2.GetType().GetProperty(name);
//                Assert.IsNotNull(p, $"No property with name '{name}' found.");
//                var expected = property.GetValue(obj1);
//                var actual = p.GetValue(obj2);
//                Assert.AreEqual(expected, actual, $"For property '{name}'.");
//            }
//        }
//        protected static void TestArePropertyValuesNotEqual(object obj1, object obj2) {
//            foreach (var property in obj1.GetType().GetProperties()) {
//                var name = property.Name;
//                var p = obj2.GetType().GetProperty(name);
//                Assert.IsNotNull(p, $"No property with name '{name}' found.");
//                var expected = property.GetValue(obj1);
//                var actual = p.GetValue(obj2);

//                if (expected != actual) return;
//            }

//            Assert.Fail("All properties are same");
//        }
//    }
//}