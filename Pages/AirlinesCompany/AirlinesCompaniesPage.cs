using Airport.Data.AirlinesCompany;
using Airport.Domain.AirlinesCompany;
using Airport.Facade.AirlinesCompany;

namespace Airport.Pages.AirlinesCompany
{
    public abstract class AirlinesCompaniesPage:CommonPage<IAirlinesCompaniesRepository, Domain.AirlinesCompany.AirlinesCompany, AirlineCompanyView, AirlinesCompanyData>
    {
        protected internal AirlinesCompaniesPage(IAirlinesCompaniesRepository r) : base(r)
        {
            PageTitle = "Airport Company";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/AirlinesCompany";

        protected internal override Domain.AirlinesCompany.AirlinesCompany ToObject(AirlineCompanyView view) => AirlineCompanyViewFactory.Create(view);
        protected internal override AirlineCompanyView ToView(Domain.AirlinesCompany.AirlinesCompany obj) => AirlineCompanyViewFactory.Create(obj);
    }
}
