using System;
using System.Linq.Expressions;
using Airport.Aids;
using Airport.Data.Flight;
using Airport.Domain.Flight;
using Airport.Facade.Flight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Aids
{
    [TestClass]
    public class GetMemberTests : BaseTests
    {
        [TestInitialize]
        public void TestInitialize() => type = typeof(GetMember);

        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual("Data", GetMember.Name<Flight>(o => o.Data));
            //Assert.AreEqual("Name", GetMember.Name<FlightData>(o => o.Name));
            Assert.AreEqual("NameTest", GetMember.Name<GetMemberTests>(o => o.NameTest()));
            Assert.AreEqual(string.Empty, GetMember.Name((Expression<Func<FlightData, object>>)null));
            Assert.AreEqual(string.Empty, GetMember.Name((Expression<Action<FlightData>>)null));
        }

        [TestMethod]
        public void DisplayNameTest()
        {
            //Assert.AreEqual("Name", GetMember.DisplayName<FlightView>(o => o.Name));
            Assert.AreEqual(string.Empty, GetMember.DisplayName<FlightView>(null));
        }
    }
}
