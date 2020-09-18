using Airport.Data.FlightsPassenger;
using Airport.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.FlightsPassenger
{
    [TestClass]
    public class FlightsPassengerTests : SealedClassTests<global::Airport.Domain.FlightsPassenger.FlightsPassenger, Entity<FlightsPassengerData>> { }
}