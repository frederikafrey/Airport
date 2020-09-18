using Airport.Aids;
using Airport.Data.Flight;

namespace Airport.Facade.Flight
{
    public static class FlightViewFactory
    {
        public static Domain.Flight.Flight Create(FlightView view)
        {
            var d = new FlightData();
            Copy.Members(view, d);

            return new Domain.Flight.Flight(d);
        }

        public static FlightView Create(Domain.Flight.Flight o)
        {
            var v = new FlightView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
