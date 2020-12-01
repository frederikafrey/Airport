using Airport.Data.Common;
using Airport.Data.Flight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Flight
{
    [TestClass]
    public class FlightDataTests : SealedClassTests<FlightData, UniqueEntityData>
    {
        [TestMethod]
        public void StartCountryTest() => IsNullableProperty(() => obj.StartCountry, x => obj.StartCountry = x);

        [TestMethod]
        public void FinalCountryTest() => IsNullableProperty(() => obj.FinalCountry, x => obj.FinalCountry = x);

        [TestMethod]
        public void StartCityTest() => IsNullableProperty(() => obj.StartCity, x => obj.StartCity = x);

        [TestMethod]
        public void FinalCityTest() => IsNullableProperty(() => obj.FinalCity, x => obj.FinalCity = x);

        [TestMethod]
        public void StopOverTest() => IsNullableProperty(() => obj.StopOver, x => obj.StopOver = x);

        [TestMethod]
        public void StartTimeTest() => IsNullableProperty(() => obj.StartTime, x => obj.StartTime = x);

        [TestMethod]
        public void ArrivalTimeTest() => IsNullableProperty(() => obj.ArrivalTime, x => obj.ArrivalTime = x);

        [TestMethod]
        public void OccupancyTest() => IsProperty<int>();

        [TestMethod]
        public void CompanyTest() => IsNullableProperty(() => obj.Company, x => obj.Company = x);

        [TestMethod]
        public void PlaneTest() => IsNullableProperty(() => obj.Plane, x => obj.Plane = x);
    }
}
