using Airport.Data.AirportOfFlight;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.AirportOfFlight
{
    [TestClass]
    public class AirportOfFlightDataTests : SealedClassTests<AirportOfFlightData, UniqueEntityData>
    {
        [TestMethod]
        public void FlightIdTest() => IsNullableProperty(() => obj.FlightId, x => obj.FlightId = x);

        [TestMethod]
        public void AirportIdTest() => IsNullableProperty(() => obj.AirportId, x => obj.AirportId = x);
    }
}
