using Airport.Aids;
using Airport.Data.PassengersFlight;

namespace Airport.Facade.PassengersFlight
{
    public static class PassengersFlightViewFactory
    {
        public static Domain.PassengersFlight.PassengersFlight Create(PassengersFlightView view)
        {
            var d = new PassengersFlightData();
            Copy.Members(view, d);

            return new Domain.PassengersFlight.PassengersFlight(d);
        }

        public static PassengersFlightView Create(Domain.PassengersFlight.PassengersFlight o)
        {
            var v = new PassengersFlightView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
