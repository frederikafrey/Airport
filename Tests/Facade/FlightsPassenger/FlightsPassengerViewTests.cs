using Airport.Facade.Common;
using Airport.Facade.FlightsPassenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.FlightsPassenger
{
    [TestClass]
    public class FlightsPassengerViewTests : SealedClassTests<FlightsPassengerView, UniqueEntityView>
    {
        [TestMethod]
        public void FlightIdTest() => IsNullableProperty(() => obj.FlightId, x => obj.FlightId = x);

        [TestMethod]
        public void PassengersFlightIdTest() => IsNullableProperty(() => obj.PassengersFlightId, x => obj.PassengersFlightId = x);

        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.PassengersFlightId}.{obj.FlightId}";
            Assert.AreEqual(expected, actual);
        }
    }
}
