using Airport.Aids;
using Airport.Data.AirlinesCompany;

namespace Airport.Facade.AirlinesCompany
{
    public static class AirlinesCompanyViewFactory
    {
        public static Domain.AirlinesCompany.AirlinesCompany Create(AirlinesCompanyView view)
        {
            var d = new AirlinesCompanyData();
            Copy.Members(view, d);

            return new Domain.AirlinesCompany.AirlinesCompany(d);
        }

        public static AirlinesCompanyView Create(Domain.AirlinesCompany.AirlinesCompany o)
        {
            var v = new AirlinesCompanyView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
