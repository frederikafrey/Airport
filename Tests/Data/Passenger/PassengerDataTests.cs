using Airport.Data.Common;
using Airport.Data.Passenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Data.Passenger
{
    [TestClass]
    public class PassengerDataTests : SealedClassTests<PassengerData, UniqueEntityData>
    {
        [TestMethod]
        public void NameTest() => IsNullableProperty(() => obj.Name, x => obj.Name = x);

        [TestMethod]
        public void AgeTest() => IsProperty<int>();

        [TestMethod]
        public void AddressTest() => IsNullableProperty(() => obj.Address, x => obj.Address = x);
    }
}
