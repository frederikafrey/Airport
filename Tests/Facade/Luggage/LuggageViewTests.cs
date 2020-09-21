using Airport.Facade.Common;
using Airport.Facade.Luggage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.Luggage
{
    [TestClass]
    public class LuggageViewTests : SealedClassTests<LuggageView, UniqueEntityView>
    {
        [TestMethod]
        public void PassengerIdTest() => IsNullableProperty(() => obj.PassengerId, x => obj.PassengerId = x);

        [TestMethod]
        public void DimensionsTest() => IsNullableProperty(() => obj.Dimensions, x => obj.Dimensions = x);

        [TestMethod]
        public void WeightTest() => IsNullableProperty(() => obj.Weight, x => obj.Weight = x);
    }
}
