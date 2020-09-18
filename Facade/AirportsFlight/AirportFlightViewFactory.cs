using Airport.Aids;
using Airport.Data.AirportsFlight;

namespace Airport.Facade.AirportsFlight
{
    public static class AirportFlightViewFactory
    {
        public static Domain.AirportsFlight.AirportsFlight Create(AirportFlightView view)
        {
            var d = new AirportsFlightData();
            Copy.Members(view, d);

            return new Domain.AirportsFlight.AirportsFlight(d);
        }

        public static AirportFlightView Create(Domain.AirportsFlight.AirportsFlight o)
        {
            var v = new AirportFlightView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
