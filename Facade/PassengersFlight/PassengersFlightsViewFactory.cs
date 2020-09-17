using Airport.Aids;
using Airport.Data.PassengersFlight;

namespace Airport.Facade.PassengersFlight
{
    public static class PassengersFlightsViewFactory
    {
        public static Domain.PassengersFlight.PassengersFlight Create(PassengersFlightsView view)
        {
            var d = new PassengersFlightData();
            Copy.Members(view, d);

            return new Domain.PassengersFlight.PassengersFlight(d);
        }

        public static PassengersFlightsView Create(Domain.PassengersFlight.PassengersFlight o)
        {
            var v = new PassengersFlightsView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
