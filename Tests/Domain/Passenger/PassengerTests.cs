using Airport.Data.Passenger;
using Airport.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Domain.Passenger
{
    [TestClass]
    public class PassengerTests : SealedClassTests<global::Airport.Domain.Passenger.Passenger, Entity<PassengerData>> { }
}
