﻿//using System;
//using System.Linq.Expressions;
//using Airport.Aids;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Tests.Aids
//{
//    [TestClass]
//    public class GetMemberTests : BaseTests
//    {
//        [TestInitialize]
//        public void TestInitialize() => type = typeof(GetMember);

//        [TestMethod]
//        public void NameTest()
//        {
//            Assert.AreEqual("Data", GetMember.Name<Coach>(o => o.Data));
//            Assert.AreEqual("Name", GetMember.Name<CoachData>(o => o.Name));
//            Assert.AreEqual("NameTest", GetMember.Name<GetMemberTests>(o => o.NameTest()));
//            Assert.AreEqual(string.Empty, GetMember.Name((Expression<Func<CoachData, object>>) null));
//            Assert.AreEqual(string.Empty, GetMember.Name((Expression<Action<CoachData>>) null));
//        }

//        [TestMethod]
//        public void DisplayNameTest()
//        {
//            Assert.AreEqual("Name", GetMember.DisplayName<CoachView>(o => o.Name));
//            Assert.AreEqual(string.Empty, GetMember.DisplayName<CoachView>(null));
//        }
//    }
//}
