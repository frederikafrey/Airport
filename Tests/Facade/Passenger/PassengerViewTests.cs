using Airport.Facade.Common;
using Airport.Facade.Passenger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airport.Tests.Facade.Passenger
{
    [TestClass]
    public class PassengerViewTests : SealedClassTests<PassengerView, UniqueEntityView>
    {
        [TestMethod]
        public void NameTest() => IsNullableProperty(() => obj.Name, x => obj.Name = x);

        [TestMethod]
        public void AddressTest() => IsNullableProperty(() => obj.Address, x => obj.Address = x);

        [TestMethod]
        public void AgeTest() => IsProperty<int>();
    }
}
