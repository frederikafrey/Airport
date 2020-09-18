using Airport.Aids;
using Airport.Data.FlightsPassenger;

namespace Airport.Facade.FlightsPassenger
{
    public static class FlightPassengerViewFactory
    {
        public static Domain.FlightsPassenger.FlightsPassenger Create(FlightPassengerView view)
        {
            var d = new FlightsPassengerData();
            Copy.Members(view, d);

            return new Domain.FlightsPassenger.FlightsPassenger(d);
        }

        public static FlightPassengerView Create(Domain.FlightsPassenger.FlightsPassenger o)
        {
            var v = new FlightPassengerView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
