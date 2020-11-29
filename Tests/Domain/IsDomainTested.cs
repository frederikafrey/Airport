using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain
{
    [TestClass]
    public class IsDomainTested : AssemblyTests
    {
        private new const string assembly = "Airport.Domain";

        protected override string Namespace(string name) => $"{assembly}.{name}";

        [TestMethod]
        public void IsAirlineCompanyTested() => IsAllTested(assembly, Namespace("AirlineCompany"));

        [TestMethod]
        public void IsAirportTested() => IsAllTested(assembly, Namespace("Airport"));

        [TestMethod]
        public void IsApiTested() => IsAllTested(assembly, Namespace("Api"));

        [TestMethod]
        public void IsApiCarrierTested() => IsAllTested(assembly, Namespace("Api.ApiCarrier"));

        [TestMethod]
        public void IsApiCityTested() => IsAllTested(assembly, Namespace("Api.ApiCity"));

        [TestMethod]
        public void IsApiCountryTested() => IsAllTested(assembly, Namespace("Api.ApiCountry"));

        [TestMethod]
        public void IsApiCurrencyTested() => IsAllTested(assembly, Namespace("Api.ApiCurrency"));

        [TestMethod]
        public void IsCommonTested() => IsAllTested(assembly, Namespace("Common"));

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
        public void IsTested() => IsAllTested(base.Namespace("Domain"));
    }
}