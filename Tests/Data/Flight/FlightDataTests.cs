using Airport.Data.Common;
using Airport.Data.Flight;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public void StartTimeTest() => IsProperty<int>();

        [TestMethod]
        public void ArrivingTimeTest() => IsProperty<int>();

        [TestMethod]
        public void OccupancyTest() => IsProperty<int>();

        [TestMethod]
        public void CompanyTest() => IsNullableProperty(() => obj.Company, x => obj.Company = x);

        [TestMethod]
        public void PlaneIdTest() => IsNullableProperty(() => obj.PlaneId, x => obj.PlaneId = x);
    }
}
