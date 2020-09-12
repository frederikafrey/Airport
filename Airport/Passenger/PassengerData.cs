using Data.Common;

namespace Data.Passenger
{
    public sealed class PassengerData: UniqueEntityData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
