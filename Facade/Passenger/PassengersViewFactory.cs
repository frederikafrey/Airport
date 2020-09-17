using Airport.Aids;
using Airport.Data.Passenger;

namespace Airport.Facade.Passenger
{
    public static class PassengersViewFactory
    {
        public static Domain.Passenger.Passenger Create(PassengersView view)
        {
            var d = new PassengerData();
            Copy.Members(view, d);

            return new Domain.Passenger.Passenger(d);
        }

        public static PassengersView Create(Domain.Passenger.Passenger o)
        {
            var v = new PassengersView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
