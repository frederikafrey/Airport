using Airport.Data.Common;
using Airport.Data.Luggage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Luggage
{
    [TestClass]
    public class LuggageDataTests : SealedClassTests<LuggageData, UniqueEntityData>
    {
        [TestMethod]
        public void FlightOfPassengerIdTest() => IsNullableProperty(() => obj.FlightOfPassengerId, x => obj.FlightOfPassengerId = x);

        [TestMethod]
        public void DimensionsTest() => IsProperty<int>();

        [TestMethod]
        public void WeightTest() => IsProperty<int>();
    }
}
