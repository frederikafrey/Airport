using Airport.Aids;
using Airport.Data.FlightsPassenger;

namespace Airport.Facade.FlightsPassenger
{
    public static class FlightsPassengersViewFactory
    {
        public static Domain.FlightsPassenger.FlightsPassenger Create(FlightsPassengersView view)
        {
            var d = new FlightsPassengerData();
            Copy.Members(view, d);

            return new Domain.FlightsPassenger.FlightsPassenger(d);
        }

        public static FlightsPassengersView Create(Domain.FlightsPassenger.FlightsPassenger o)
        {
            var v = new FlightsPassengersView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
