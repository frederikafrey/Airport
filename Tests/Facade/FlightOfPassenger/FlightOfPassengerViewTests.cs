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
        public void StartDestinationTest() => IsNullableProperty(() => obj.StartDestination, x => obj.StartDestination = x);

        [TestMethod]
        public void FinalDestinationTest() => IsNullableProperty(() => obj.FinalDestination, x => obj.FinalDestination = x);

        [TestMethod]
        public void StopOverIdTest() => IsNullableProperty(() => obj.StopOverId, x => obj.StopOverId = x);

        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.StopOverId}.{obj.PassengerId}";
            Assert.AreEqual(expected, actual);
        }
    }
}
