using Airport.Data.Common;
using Airport.Data.Flight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Flight
{
    [TestClass]
    public class FlightDataTests : SealedClassTests<FlightData, UniqueEntityData>
    {
        [TestMethod]
        public void StartingPointIdTest() => IsNullableProperty(() => obj.StartingPointId, x => obj.StartingPointId = x);

        [TestMethod]
        public void FinalPointIdTest() => IsNullableProperty(() => obj.FinalPointId, x => obj.FinalPointId = x);

        [TestMethod]
        public void StartTimeTest() => IsNullableProperty(() => obj.StartTime, x => obj.StartTime = x);

        [TestMethod]
        public void ArrivingTimeTest() => IsNullableProperty(() => obj.ArrivingTime, x => obj.ArrivingTime = x);

        [TestMethod]
        public void OccupancyTest() => IsNullableProperty(() => obj.Occupancy, x => obj.Occupancy = x);

        [TestMethod]
        public void CompanyTest() => IsNullableProperty(() => obj.Company, x => obj.Company = x);

        [TestMethod]
        public void PlaneIdTest() => IsNullableProperty(() => obj.PlaneId, x => obj.PlaneId = x);
    }
}
