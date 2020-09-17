using Airport.Data.AirlinesCompany;
using Airport.Domain.AirlinesCompany;
using Airport.Facade.AirlinesCompany;

namespace Airport.Pages.AirlinesCompany
{
    public abstract class AirlinesCompaniesPage:CommonPage<IAirlinesCompaniesRepository, Domain.AirlinesCompany.AirlinesCompany, AirlinesCompaniesView, AirlinesCompanyData>
    {
        protected internal AirlinesCompaniesPage(IAirlinesCompaniesRepository r) : base(r)
        {
            PageTitle = "Airport Company";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/AirlinesCompany";

        protected internal override Domain.AirlinesCompany.AirlinesCompany ToObject(AirlinesCompaniesView view) => AirlinesCompaniesViewFactory.Create(view);
        protected internal override AirlinesCompaniesView ToView(Domain.AirlinesCompany.AirlinesCompany obj) => AirlinesCompaniesViewFactory.Create(obj);
    }
}
