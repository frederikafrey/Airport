using Airport.Aids;
using Airport.Data.AirportOfFlight;

namespace Airport.Facade.AirportOfFlight
{
    public static class AirportOfFlightViewFactory
    {
        public static Domain.AirportOfFlight.AirportOfFlight Create(AirportOfFlightView view)
        {
            var d = new AirportOfFlightData();
            Copy.Members(view, d);

            return new Domain.AirportOfFlight.AirportOfFlight(d);
        }

        public static AirportOfFlightView Create(Domain.AirportOfFlight.AirportOfFlight o)
        {
            var v = new AirportOfFlightView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
