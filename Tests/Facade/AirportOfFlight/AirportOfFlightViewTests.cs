using Airport.Facade.AirportOfFlight;
using Airport.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.AirportOfFlight
{
    [TestClass]
    public class AirportOfFlightViewTests : SealedClassTests<AirportOfFlightView, UniqueEntityView>
    {
        [TestMethod]
        public void FlightIdTest() => IsNullableProperty(() => obj.FlightId, x => obj.FlightId = x);

        [TestMethod]
        public void AirportIdTest() => IsNullableProperty(() => obj.AirportId, x => obj.AirportId = x);

        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.AirportId}.{obj.FlightId}";
            Assert.AreEqual(expected, actual);
        }
    }
}
