using Airport.Data.Common;
using Airport.Data.FlightOfPassenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.FlightOfPassenger
{
    [TestClass]
    public class FlightOfPassengerDataTests : SealedClassTests<FlightOfPassengerData, UniqueEntityData>
    {
        [TestMethod]
        public void PassengerIdTest() => IsNullableProperty(() => obj.PassengerId, x => obj.PassengerId = x);

        [TestMethod]
        public void LuggageIdTest() => IsNullableProperty(() => obj.LuggageId, x => obj.LuggageId = x);

        [TestMethod]
        public void FlightIdTest() => IsNullableProperty(() => obj.FlightId, x => obj.FlightId = x);

        //[TestMethod]
        //public void QuoteIdTest() => IsNullableProperty(() => obj.QuoteId, x => obj.QuoteId = x);
    }
}
