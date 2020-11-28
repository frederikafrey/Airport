using Airport.Data.Common;
using Airport.Data.StopOver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.StopOver
{
    [TestClass]
    public class StopOverDataTests : SealedClassTests<StopOverData, UniqueEntityData>
    {
        [TestMethod]
        public void CountryTest() => IsNullableProperty(() => obj.Country, x => obj.Country = x);

        [TestMethod]
        public void CityTest() => IsNullableProperty(() => obj.City, x => obj.City = x);
    }
}
