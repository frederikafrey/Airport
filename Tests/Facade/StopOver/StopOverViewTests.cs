using Airport.Facade.Common;
using Airport.Facade.StopOver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.StopOver
{
    [TestClass]
    public class StopOverViewTests : SealedClassTests<StopOverView, UniqueEntityView>
    {
        [TestMethod]
        public void FlightIdTest() => IsNullableProperty(() => obj.FlightId, x => obj.FlightId = x);

        [TestMethod]
        public void FlightOfPassengerIdTest() => IsNullableProperty(() => obj.FlightOfPassengerId, x => obj.FlightOfPassengerId = x);

        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.FlightOfPassengerId}.{obj.FlightId}";
            Assert.AreEqual(expected, actual);
        }
    }
}
