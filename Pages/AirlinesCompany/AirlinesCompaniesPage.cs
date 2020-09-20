using Airport.Data.AirlinesCompany;
using Airport.Domain.AirlinesCompany;
using Airport.Facade.AirlinesCompany;

namespace Airport.Pages.AirlinesCompany
{
    public abstract class AirlinesCompaniesPage:CommonPage<IAirlinesCompaniesRepository, Domain.AirlinesCompany.AirlinesCompany, AirlinesCompanyView, AirlinesCompanyData>
    {
        protected internal AirlinesCompaniesPage(IAirlinesCompaniesRepository r) : base(r)
        {
            PageTitle = "Airport Company";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Airport/AirlinesCompany";

        public override Domain.AirlinesCompany.AirlinesCompany ToObject(AirlinesCompanyView view) => AirlinesCompanyViewFactory.Create(view);
        public override AirlinesCompanyView ToView(Domain.AirlinesCompany.AirlinesCompany obj) => AirlinesCompanyViewFactory.Create(obj);
    }
}
