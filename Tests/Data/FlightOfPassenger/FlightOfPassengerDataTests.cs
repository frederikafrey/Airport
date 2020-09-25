using Airport.Data.Common;
using Airport.Data.FlightOfPassenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.FlightOfPassenger
{
    [TestClass]
    public class FlightOfPassengerDataTests : SealedClassTests<FlightOfPassengerData, UniqueEntityData>
    {
        [TestMethod]
        public void PassengerIdTest() => IsNullableProperty(() => obj.PassengerId, x => obj.PassengerId = x);

        [TestMethod]
        public void PassengerOfFlightIdTest() => IsNullableProperty(() => obj.PassengerOfFlightId, x => obj.PassengerOfFlightId = x);

        [TestMethod]
        public void StartDestinationIdTest() => IsNullableProperty(() => obj.StartDestinationId, x => obj.StartDestinationId = x);

        [TestMethod]
        public void FinalDestinationIdTest() => IsNullableProperty(() => obj.FinalDestinationId, x => obj.FinalDestinationId = x);
    }
}
