using Airport.Aids;
using Airport.Data.Passenger;
using Airport.Facade.Passenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Aids
{

    [TestClass]
    public class CopyTests : BaseTests
    {

        [TestInitialize] public void TestInitialize() => type = typeof(Copy);

        [TestMethod]
        public void MembersTest()
        {
            var x = GetRandom.Object<PassengerData>();
            var y = GetRandom.Object<PassengersView>();
            TestArePropertyValuesNotEqual(x, y);
            Copy.Members(x, y);
            TestArePropertyValuesEqual(x, y);
        }
    }
}
