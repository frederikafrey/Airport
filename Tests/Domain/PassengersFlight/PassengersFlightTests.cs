using Airport.Data.PassengersFlight;
using Airport.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.PassengersFlight
{
    [TestClass]
    public class PassengersFlightTests : SealedClassTests<global::Airport.Domain.PassengersFlight.PassengersFlight, Entity<PassengersFlightData>> { }
}
