using Airport.Data.AirlineCompany;
using Airport.Domain.AirlineCompany;
using Airport.Domain.Api;
using Airport.Facade.AirlineCompany;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Airport.Pages.AirlineCompany
{
    public abstract class AirlineCompaniesPage:CommonPage<IAirlineCompaniesRepository, Domain.AirlineCompany.AirlineCompany, AirlineCompanyView, AirlineCompanyData>
    {
        protected internal AirlineCompaniesPage(IAirlineCompaniesRepository r, IApiCarriersRepository c) : base(r)
        {
            PageTitle = "Airline Companies";
            Carrier = CreateSelectList(c);
        }

        public IEnumerable<SelectListItem> Carrier { get; }
        public override string ItemId => Item?.Id ?? string.Empty;

        public override string GetPageUrl() => "/AirlineCompany/AirlineCompanies";

        public override Domain.AirlineCompany.AirlineCompany ToObject(AirlineCompanyView view) => AirlineCompanyViewFactory.Create(view);

        public override AirlineCompanyView ToView(Domain.AirlineCompany.AirlineCompany obj) => AirlineCompanyViewFactory.Create(obj);
    }
}
