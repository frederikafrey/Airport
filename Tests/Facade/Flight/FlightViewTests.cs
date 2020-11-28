using Airport.Facade.Common;
using Airport.Facade.Flight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.Flight
{
    [TestClass]
    public class FlightViewTests : SealedClassTests<FlightView, UniqueEntityView>
    {
        [TestMethod]
        public void StartingPointTest() => IsNullableProperty(() => obj.StartingPoint, x => obj.StartingPoint = x);

        [TestMethod]
        public void StartCityTest() => IsNullableProperty(() => obj.StartCity, x => obj.StartCity = x);

        [TestMethod]
        public void FinalPointTest() => IsNullableProperty(() => obj.FinalPoint, x => obj.FinalPoint = x);

        [TestMethod]
        public void FinalCityTest() => IsNullableProperty(() => obj.FinalCity, x => obj.FinalCity = x);

        [TestMethod]
        public void StartTimeTest() => IsNullableProperty(() => obj.StartTime, x => obj.StartTime = x);

        [TestMethod]
        public void StopOverTest() => IsNullableProperty(() => obj.StopOver, x => obj.StopOver = x);

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
