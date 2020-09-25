using Airport.Aids;
using Airport.Data.PassengerOfFlight;

namespace Airport.Facade.PassengerOfFlight
{
    public static class PassengerOfFlightViewFactory
    {
        public static Domain.PassengerOfFlight.PassengerOfFlight Create(PassengerOfFlightView ofFlightView)
        {
            var d = new PassengerOfFlightData();
            Copy.Members(ofFlightView, d);

            return new Domain.PassengerOfFlight.PassengerOfFlight(d);
        }

        public static PassengerOfFlightView Create(Domain.PassengerOfFlight.PassengerOfFlight o)
        {
            var v = new PassengerOfFlightView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
