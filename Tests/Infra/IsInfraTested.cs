using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Infra
{
    [TestClass]
    public class IsInfraTested : AssemblyTests
    {
        private new const string assembly = "Airport.Infra";

        protected override string Namespace(string name) => $"{assembly}.{name}";

        [TestMethod]
        public void IsAirlineCompanyTested() => IsAllTested(assembly, Namespace("AirlineCompany"));

        [TestMethod]
        public void IsAirportTested() => IsAllTested(assembly, Namespace("Airport"));

        [TestMethod]
        public void IsApiTested() => IsAllTested(assembly, Namespace("Api"));

        [TestMethod]
        public void IsFlightTested() => IsAllTested(assembly, Namespace("Flight"));

        [TestMethod]
        public void IsStopOverTested() => IsAllTested(assembly, Namespace("StopOver"));

        [TestMethod]
        public void IsLuggageTested() => IsAllTested(assembly, Namespace("Luggage"));

        [TestMethod]
        public void IsPassengerTested() => IsAllTested(assembly, Namespace("Passenger"));

        [TestMethod]
        public void IsFlightOfPassengerTested() => IsAllTested(assembly, Namespace("FlightOfPassenger"));

        [TestMethod]
        public void IsTested() => IsAllTested(base.Namespace("Infra"));
    }
}
