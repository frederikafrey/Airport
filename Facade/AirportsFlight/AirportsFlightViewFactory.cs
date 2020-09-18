using Airport.Aids;
using Airport.Data.AirportsFlight;

namespace Airport.Facade.AirportsFlight
{
    public static class AirportsFlightViewFactory
    {
        public static Domain.AirportsFlight.AirportsFlight Create(AirportsFlightView view)
        {
            var d = new AirportsFlightData();
            Copy.Members(view, d);

            return new Domain.AirportsFlight.AirportsFlight(d);
        }

        public static AirportsFlightView Create(Domain.AirportsFlight.AirportsFlight o)
        {
            var v = new AirportsFlightView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
