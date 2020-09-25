using Airport.Data.Common;
using Airport.Data.PassengerOfFlight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.PassengerOfFlight
{
    [TestClass]
    public class PassengerOfFlightDataTests : SealedClassTests<PassengerOfFlightData, UniqueEntityData>
    {
        [TestMethod]
        public void FlightIdTest() => IsNullableProperty(() => obj.FlightId, x => obj.FlightId = x);

        [TestMethod]
        public void FlightOfPassengerIdTest() => IsNullableProperty(() => obj.FlightOfPassengerId, x => obj.FlightOfPassengerId = x);
    }
}
