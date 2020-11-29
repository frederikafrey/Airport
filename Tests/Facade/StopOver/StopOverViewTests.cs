using Airport.Facade.Common;
using Airport.Facade.StopOver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.StopOver
{
    [TestClass]
    public class StopOverViewTests : SealedClassTests<StopOverView, UniqueEntityView>
    {
        [TestMethod]
        public void CountryTest() => IsNullableProperty(() => obj.Country, x => obj.Country = x);

        [TestMethod]
        public void CityTest() => IsNullableProperty(() => obj.City, x => obj.City = x);

        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.Country}.{obj.City}";
            Assert.AreEqual(expected, actual);
        }
    }
}
