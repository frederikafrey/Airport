using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain
{
    [TestClass]
    public class IsDomainTested : AssemblyTests
    {
        private new const string assembly = "Airport.Domain";

        protected override string Namespace(string name) => $"{assembly}.{name}";

        [TestMethod]
        public void IsAirlinesCompanyTested() => IsAllTested(assembly, Namespace("AirlinesCompany"));

        [TestMethod]
        public void IsAirportTested() => IsAllTested(assembly, Namespace("Airport"));

        [TestMethod]
        public void IsAirportsFlightTested() => IsAllTested(assembly, Namespace("AirportsFlight"));

        [TestMethod]
        public void IsCommonTested() => IsAllTested(assembly, Namespace("Common"));

        [TestMethod]
        public void IsFlightTested() => IsAllTested(assembly, Namespace("Flight"));

        [TestMethod]
        public void IsFlightsPassengerTested() => IsAllTested(assembly, Namespace("FlightsPassenger"));

        [TestMethod]
        public void IsLuggageTested() => IsAllTested(assembly, Namespace("Luggage"));

        [TestMethod]
        public void IsPassengerTested() => IsAllTested(assembly, Namespace("Passenger"));

        [TestMethod]
        public void IsPassengersFlightTested() => IsAllTested(assembly, Namespace("PassengersFlight"));

        [TestMethod]
        public void IsTested() => IsAllTested(base.Namespace("Domain"));
    }
}