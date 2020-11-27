using Airport.Facade.Common;
using Airport.Facade.Luggage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.Luggage
{
    [TestClass]
    public class LuggageViewTests : SealedClassTests<LuggageView, UniqueEntityView>
    {
        //[TestMethod]
        //public void FlightOfPassengerIdTest() => IsNullableProperty(() => obj.FlightOfPassengerId, x => obj.FlightOfPassengerId = x);

        [TestMethod]
        public void DimensionsTest() => IsProperty<int>();

        [TestMethod]
        public void WeightTest() => IsProperty<int>();
    }
}
