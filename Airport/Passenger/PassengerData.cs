using Airport.Data.Common;

namespace Airport.Data.Passenger
{
    public sealed class PassengerData : UniqueEntityData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
