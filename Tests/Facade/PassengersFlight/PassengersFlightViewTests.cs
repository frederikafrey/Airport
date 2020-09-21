using Airport.Facade.Common;
using Airport.Facade.PassengersFlight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.PassengersFlight
{
    [TestClass]
    public class PassengersFlightViewTests : SealedClassTests<PassengersFlightView, UniqueEntityView>
    {
        [TestMethod]
        public void PassengerIdTest() => IsNullableProperty(() => obj.PassengerId, x => obj.PassengerId = x);

        [TestMethod]
        public void FlightsPassengerIdTest() => IsNullableProperty(() => obj.FlightsPassengerId, x => obj.FlightsPassengerId = x);

        [TestMethod]
        public void StartDestinationIdTest() => IsNullableProperty(() => obj.StartDestinationId, x => obj.StartDestinationId = x);

        [TestMethod]
        public void FinalDestinationIdTest() => IsNullableProperty(() => obj.FinalDestinationId, x => obj.FinalDestinationId = x);

        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.FlightsPassengerId}.{obj.PassengerId}";
            Assert.AreEqual(expected, actual);
        }
    }
}
