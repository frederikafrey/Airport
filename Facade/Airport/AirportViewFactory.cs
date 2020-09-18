using Airport.Aids;
using Airport.Data.Airport;

namespace Airport.Facade.Airport
{
    public static class AirportViewFactory
    {
        public static Domain.Airport.Airport Create(AirportView view)
        {
            var d = new AirportData();
            Copy.Members(view, d);

            return new Domain.Airport.Airport(d);
        }

        public static AirportView Create(Domain.Airport.Airport o)
        {
            var v = new AirportView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
