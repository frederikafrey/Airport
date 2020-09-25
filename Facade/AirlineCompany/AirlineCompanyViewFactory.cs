using Airport.Aids;
using Airport.Data.AirlineCompany;

namespace Airport.Facade.AirlineCompany
{
    public static class AirlineCompanyViewFactory
    {
        public static Domain.AirlineCompany.AirlineCompany Create(AirlineCompanyView view)
        {
            var d = new AirlineCompanyData();
            Copy.Members(view, d);

            return new Domain.AirlineCompany.AirlineCompany(d);
        }

        public static AirlineCompanyView Create(Domain.AirlineCompany.AirlineCompany o)
        {
            var v = new AirlineCompanyView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
