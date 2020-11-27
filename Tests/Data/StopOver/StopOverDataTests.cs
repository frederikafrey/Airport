using Airport.Data.Common;
using Airport.Data.StopOver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.StopOver
{
    [TestClass]
    public class StopOverDataTests : SealedClassTests<StopOverData, UniqueEntityData>
    {
        [TestMethod]
        public void FlightIdTest() => IsNullableProperty(() => obj.Country, x => obj.Country = x);

        [TestMethod]
        public void FlightOfPassengerIdTest() => IsNullableProperty(() => obj.City, x => obj.City = x);
    }
}
