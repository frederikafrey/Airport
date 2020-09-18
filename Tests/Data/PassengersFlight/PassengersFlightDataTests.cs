using Airport.Data.Common;
using Airport.Data.PassengersFlight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.PassengersFlight
{
    [TestClass]
    public class PassengersFlightDataTests : SealedClassTests<PassengersFlightData, UniqueEntityData>
    {
        [TestMethod]
        public void PassengerIdTest() => IsNullableProperty(() => obj.PassengerId, x => obj.PassengerId = x);

        [TestMethod]
        public void FlightsPassengerIdTest() => IsNullableProperty(() => obj.FlightsPassengerId, x => obj.FlightsPassengerId = x);

        [TestMethod]
        public void StartDestinationIdTest() => IsNullableProperty(() => obj.StartDestinationId, x => obj.StartDestinationId = x);

        [TestMethod]
        public void FinalDestinationIdTest() => IsNullableProperty(() => obj.FinalDestinationId, x => obj.FinalDestinationId = x);
    }
}
