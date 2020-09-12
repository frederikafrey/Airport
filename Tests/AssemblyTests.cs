﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Tests
//{
//    public class AssemblyTests
//    {
//        private static string isNotTested => "<{0}> is not tested";
//        private static string noClassesInAssembly => "No classes found in assembly {0}";
//        private static string noClassesInNamespace => "No classes found in namespace {0}";
//        private static string testAssembly => "SportClub.Tests";
//        protected virtual string assembly => "SportClub";
//        private static char genericsChar => '`';
//        private static char internalClass => '+';
//        private static string displayClass => "<>";
//        private static string shell32 => "Shell32.";
//        private List<string> list;

//        [TestInitialize]
//        public void CreateList() => list = new List<string>();

//        protected virtual string Namespace(string name) => $"{assembly}.{name}";

//        protected void IsAllTested(string assemblyName,
//            string namespaceName = null)
//        {
//            var l = GetAssemblyClasses(assemblyName);
//            RemoveInterfaces(l);
//            list = ToClassNamesList(l);
//            RemoveNotInNamespace(namespaceName);
//            RemoveSurrogateClasses();
//            RemoveTested();

//            if (list.Count == 0) return;

//            Report(isNotTested, list[0]);
//        }

//        private static void Report(string message, params object[] parameters) => Assert.Fail(message, parameters);

//        private static List<Type> GetAssemblyClasses(string assemblyName)
//        {
//            var l = GetSolution.TypesForAssembly(assemblyName);
//            if (l.Count == 0) Report(noClassesInAssembly, assemblyName);

//            return l;
//        }

//        private static void RemoveInterfaces(IList<Type> types)
//        {
//            for (var i = types.Count; i > 0; i--)
//            {
//                var e = types[i - 1];

//                if (!e.IsInterface) continue;

//                types.Remove(e);
//            }
//        }

//        private static List<string> ToClassNamesList(List<Type> l) => l.Select(o => o.FullName).ToList();

//        private void RemoveNotInNamespace(string namespaceName)
//        {
//            if (string.IsNullOrEmpty(namespaceName)) return;

//            list.RemoveAll(o => !o.StartsWith(namespaceName + '.'));

//            if (list.Count > 0) return;

//            Report(noClassesInNamespace, namespaceName);
//        }

//        private void RemoveSurrogateClasses()
//        {
//            list.RemoveAll(o => o.Contains(shell32));
//            list.RemoveAll(o => o.Contains(internalClass));
//            list.RemoveAll(o => o.Contains(displayClass));
//            list.RemoveAll(o => o.Contains("<"));
//            list.RemoveAll(o => o.Contains(">"));
//            list.RemoveAll(o => o.Contains("Migrations"));
//        }

//        private void RemoveTested()
//        {
//            var tests = GetTestClasses();

//            for (var i = list.Count; i > 0; i--)
//            {
//                var className = list[i - 1];
//                var testName = ToTestName(className);
//                var t = tests.Find(o => o.EndsWith(testName));

//                if (ReferenceEquals(null, t)) continue;

//                list.RemoveAt(i - 1);
//            }
//        }

//        private List<string> GetTestClasses()
//        {
//            var tests = GetSolution.TypeNamesForAssembly(testAssembly);

//            return tests.Select(t => RemoveGenericsChars(t)).ToList();
//        }

//        private string ToTestName(string className)
//        {
//            className = RemoveAssemblyName(className);
//            className = RemoveGenericsChars(className);

//            return className + "Tests";
//        }

//        private static string RemoveGenericsChars(string className)
//        {
//            var idx = className.IndexOf(genericsChar);
//            if (idx > 0) className = className.Substring(0, idx);

//            return className;
//        }

//        private string RemoveAssemblyName(string className) => className.Substring(assembly.Length);
//    }
//}
