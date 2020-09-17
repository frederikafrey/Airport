using Airport.Aids;
using Airport.Data.Airport;

namespace Airport.Facade.Airport
{
    public static class AirportsViewFactory
    {
        public static Domain.Airport.Airport Create(AirportsView view)
        {
            var d = new AirportData();
            Copy.Members(view, d);

            return new Domain.Airport.Airport(d);
        }

        public static AirportsView Create(Domain.Airport.Airport o)
        {
            var v = new AirportsView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
