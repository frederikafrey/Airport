using Airport.Data.Flight;
using Airport.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.Flight
{
    [TestClass]
    public class FlightTests : SealedClassTests<global::Airport.Domain.Flight.Flight, Entity<FlightData>> { }
}