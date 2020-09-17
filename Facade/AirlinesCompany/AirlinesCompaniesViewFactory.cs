using Airport.Aids;
using Airport.Data.AirlinesCompany;

namespace Airport.Facade.AirlinesCompany
{
    public static class AirlinesCompaniesViewFactory
    {
        public static Domain.AirlinesCompany.AirlinesCompany Create(AirlinesCompaniesView view)
        {
            var d = new AirlinesCompanyData();
            Copy.Members(view, d);

            return new Domain.AirlinesCompany.AirlinesCompany(d);
        }

        public static AirlinesCompaniesView Create(Domain.AirlinesCompany.AirlinesCompany o)
        {
            var v = new AirlinesCompaniesView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);

            return v;
        }
    }
}
