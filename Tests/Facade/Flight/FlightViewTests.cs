using Airport.Facade.Common;
using Airport.Facade.Flight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.Flight
{
    [TestClass]
    public class FlightViewTests : SealedClassTests<FlightView, UniqueEntityView>
    {
        [TestMethod]
        public void StartingPointIdTest() => IsNullableProperty(() => obj.StartingPoint, x => obj.StartingPoint = x);

        [TestMethod]
        public void FinalPointIdTest() => IsNullableProperty(() => obj.FinalPoint, x => obj.FinalPoint = x);

        [TestMethod]
        public void StartTimeTest() => IsProperty<int>();

        [TestMethod]
        public void ArrivingTimeTest() => IsProperty<int>();

        [TestMethod]
        public void OccupancyTest() => IsProperty<int>();

        [TestMethod]
        public void CompanyTest() => IsNullableProperty(() => obj.Company, x => obj.Company = x);

        [TestMethod]
        public void PlaneIdTest() => IsNullableProperty(() => obj.Plane, x => obj.Plane = x);
    }
}
