using Airport.Data.Common;
using Airport.Data.FlightsPassenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.FlightsPassenger
{
    [TestClass]
    public class FlightsPassengertDataTests : SealedClassTests<FlightsPassengerData, UniqueEntityData>
    {
        [TestMethod]
        public void FlightIdTest() => IsNullableProperty(() => obj.FlightId, x => obj.FlightId = x);

        [TestMethod]
        public void PassengersFlightIdTest() => IsNullableProperty(() => obj.PassengersFlightId, x => obj.PassengersFlightId = x);
    }
}
