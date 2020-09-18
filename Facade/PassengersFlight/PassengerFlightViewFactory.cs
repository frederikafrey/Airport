using Airport.Aids;
using Airport.Data.PassengersFlight;

namespace Airport.Facade.PassengersFlight
{
    public static class PassengerFlightViewFactory
    {
        public static Domain.PassengersFlight.PassengersFlight Create(PassengerFlightView view)
        {
            var d = new PassengersFlightData();
            Copy.Members(view, d);

            return new Domain.PassengersFlight.PassengersFlight(d);
        }

        public static PassengerFlightView Create(Domain.PassengersFlight.PassengersFlight o)
        {
            var v = new PassengerFlightView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
