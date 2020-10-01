﻿using Airport.Data.Common;
using Airport.Data.Flight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Flight
{
    [TestClass]
    public class FlightDataTests : SealedClassTests<FlightData, UniqueEntityData>
    {
        [TestMethod]
        public void StartingPointTest() => IsNullableProperty(() => obj.StartingPoint, x => obj.StartingPoint = x);

        [TestMethod]
        public void FinalPointTest() => IsNullableProperty(() => obj.FinalPoint, x => obj.FinalPoint = x);

        [TestMethod]
        public void StartTimeTest() => IsNullableProperty(() => obj.StartTime, x => obj.StartTime = x);

        [TestMethod]
        public void ArrivingTimeTest() => IsNullableProperty(() => obj.ArrivingTime, x => obj.ArrivingTime = x);

        [TestMethod]
        public void OccupancyTest() => IsProperty<int>();

        [TestMethod]
        public void CompanyTest() => IsNullableProperty(() => obj.Company, x => obj.Company = x);

        [TestMethod]
        public void PlaneTest() => IsNullableProperty(() => obj.Plane, x => obj.Plane = x);
    }
}
