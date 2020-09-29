using Airport.Data.Common;
using Airport.Data.StopOver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.StopOver
{
    [TestClass]
    public class StopOverDataTests : SealedClassTests<StopOverData, UniqueEntityData>
    {
        [TestMethod]
        public void FlightIdTest() => IsNullableProperty(() => obj.FlightId, x => obj.FlightId = x);

        [TestMethod]
        public void FlightOfPassengerIdTest() => IsNullableProperty(() => obj.FlightOfPassengerId, x => obj.FlightOfPassengerId = x);
    }
}
