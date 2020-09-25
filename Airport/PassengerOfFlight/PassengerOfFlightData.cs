using Airport.Data.Common;

namespace Airport.Data.PassengerOfFlight
{
    public sealed class PassengerOfFlightData : UniqueEntityData
    {
        public string FlightId { get; set; }
        public string FlightOfPassengerId { get; set; }
    }
}
