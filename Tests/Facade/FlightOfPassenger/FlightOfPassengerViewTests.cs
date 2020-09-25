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
        public void PassengerOfFlightIdTest() => IsNullableProperty(() => obj.PassengerOfFlightId, x => obj.PassengerOfFlightId = x);

        [TestMethod]
        public void StartDestinationIdTest() => IsNullableProperty(() => obj.StartDestinationId, x => obj.StartDestinationId = x);

        [TestMethod]
        public void FinalDestinationIdTest() => IsNullableProperty(() => obj.FinalDestinationId, x => obj.FinalDestinationId = x);

        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.PassengerOfFlightId}.{obj.PassengerId}";
            Assert.AreEqual(expected, actual);
        }
    }
}
