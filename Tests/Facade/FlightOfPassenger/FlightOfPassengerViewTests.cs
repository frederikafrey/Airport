using Airport.Facade.Common;
using Airport.Facade.FlightOfPassenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.FlightOfPassenger
{
    [TestClass]
    public class FlightOfPassengerViewTests : SealedClassTests<FlightOfPassengerView, UniqueEntityView>
    {
        [TestMethod]
        public void PassengerIdTest() => IsNullableProperty(() => obj.PassengerId, x => obj.PassengerId = x);

        [TestMethod]
        public void FlightIdTest() => IsNullableProperty(() => obj.FlightId, x => obj.FlightId = x);

        [TestMethod]
        public void LuggageIdTest() => IsNullableProperty(() => obj.LuggageId, x => obj.LuggageId = x);

        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.PassengerId}.{obj.FlightId}";
            Assert.AreEqual(expected, actual);
        }
    }
}
