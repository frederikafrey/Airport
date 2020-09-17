using Airport.Aids;
using Airport.Data.Flight;

namespace Airport.Facade.Flight
{
    public static class FlightsViewFactory
    {
        public static Domain.Flight.Flight Create(FlightsView view)
        {
            var d = new FlightData();
            Copy.Members(view, d);

            return new Domain.Flight.Flight(d);
        }

        public static FlightsView Create(Domain.Flight.Flight o)
        {
            var v = new FlightsView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
