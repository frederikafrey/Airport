using Airport.Aids;
using Airport.Data.FlightsPassenger;

namespace Airport.Facade.FlightsPassenger
{
    public static class FlightsPassengerViewFactory
    {
        public static Domain.FlightsPassenger.FlightsPassenger Create(FlightsPassengerView view)
        {
            var d = new FlightsPassengerData();
            Copy.Members(view, d);

            return new Domain.FlightsPassenger.FlightsPassenger(d);
        }

        public static FlightsPassengerView Create(Domain.FlightsPassenger.FlightsPassenger o)
        {
            var v = new FlightsPassengerView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
