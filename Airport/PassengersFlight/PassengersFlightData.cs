using Airport.Data.Common;

namespace Airport.Data.PassengersFlight
{
    public class PassengersFlightData : UniqueEntityData
    {
        public string PassengerId { get; set; }
        public string FlightsPassengerId { get; set; }
        public string StartDestinationId { get; set; }
        public string FinalDestinationId { get; set; }
    }
}
