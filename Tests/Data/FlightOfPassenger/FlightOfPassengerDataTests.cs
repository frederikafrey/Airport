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
        public void StartDestinationIdTest() => IsNullableProperty(() => obj.StartDestination, x => obj.StartDestination = x);

        [TestMethod]
        public void FinalDestinationIdTest() => IsNullableProperty(() => obj.FinalDestination, x => obj.FinalDestination = x);
    }
}
