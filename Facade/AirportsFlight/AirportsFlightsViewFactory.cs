using Airport.Aids;
using Airport.Data.AirportsFlight;

namespace Airport.Facade.AirportsFlight
{
    public static class AirportsFlightsViewFactory
    {
        public static Domain.AirportsFlight.AirportsFlight Create(AirportsFlightsView view)
        {
            var d = new AirportsFlightData();
            Copy.Members(view, d);

            return new Domain.AirportsFlight.AirportsFlight(d);
        }

        public static AirportsFlightsView Create(Domain.AirportsFlight.AirportsFlight o)
        {
            var v = new AirportsFlightsView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
