using Airport.Aids;
using Airport.Data.FlightOfPassenger;

namespace Airport.Facade.FlightOfPassenger
{
    public static class FlightOfPassengerViewFactory
    {
        public static Domain.FlightOfPassenger.FlightOfPassenger Create(FlightOfPassengerView ofPassengerView)
        {
            var d = new FlightOfPassengerData();
            Copy.Members(ofPassengerView, d);

            return new Domain.FlightOfPassenger.FlightOfPassenger(d);
        }

        public static FlightOfPassengerView Create(Domain.FlightOfPassenger.FlightOfPassenger o)
        {
            var v = new FlightOfPassengerView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
