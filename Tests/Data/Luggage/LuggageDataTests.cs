using Airport.Data.Common;
using Airport.Data.Luggage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Luggage
{
    [TestClass]
    public class LuggageDataTests : SealedClassTests<LuggageData, UniqueEntityData>
    {
        [TestMethod]
        public void PassengerIdTest() => IsNullableProperty(() => obj.PassengerId, x => obj.PassengerId = x);

        [TestMethod]
        public void NameTest() => IsNullableProperty(() => obj.Name, x => obj.Name = x);

        [TestMethod]
        public void DimensionsTest() => IsNullableProperty(() => obj.Dimensions, x => obj.Dimensions = x);

        [TestMethod]
        public void WeightTest() => IsNullableProperty(() => obj.Weight, x => obj.Weight = x);
    }
}
