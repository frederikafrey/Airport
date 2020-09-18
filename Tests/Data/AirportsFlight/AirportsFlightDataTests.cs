using Airport.Data.AirportsFlight;
using Airport.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.AirportsFlight
{
    [TestClass]
    public class AirportsFlightDataTests : SealedClassTests<AirportsFlightData, UniqueEntityData>
    {
        [TestMethod]
        public void FlightIdTest() => IsNullableProperty(() => obj.FlightId, x => obj.FlightId = x);

        [TestMethod]
        public void AirportIdTest() => IsNullableProperty(() => obj.AirportId, x => obj.AirportId = x);
    }
}
