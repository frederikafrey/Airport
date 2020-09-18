using Airport.Aids;
using Airport.Data.Passenger;

namespace Airport.Facade.Passenger
{
    public static class PassengerViewFactory
    {
        public static Domain.Passenger.Passenger Create(PassengerView view)
        {
            var d = new PassengerData();
            Copy.Members(view, d);

            return new Domain.Passenger.Passenger(d);
        }

        public static PassengerView Create(Domain.Passenger.Passenger o)
        {
            var v = new PassengerView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
