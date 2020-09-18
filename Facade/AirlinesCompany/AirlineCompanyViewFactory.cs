using Airport.Aids;
using Airport.Data.AirlinesCompany;

namespace Airport.Facade.AirlinesCompany
{
    public static class AirlineCompanyViewFactory
    {
        public static Domain.AirlinesCompany.AirlinesCompany Create(AirlineCompanyView view)
        {
            var d = new AirlinesCompanyData();
            Copy.Members(view, d);

            return new Domain.AirlinesCompany.AirlinesCompany(d);
        }

        public static AirlineCompanyView Create(Domain.AirlinesCompany.AirlinesCompany o)
        {
            var v = new AirlineCompanyView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
