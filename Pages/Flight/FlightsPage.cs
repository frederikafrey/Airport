using System.Collections.Generic;
using System.Linq;
using Airport.Data.AirlineCompany;
using Airport.Data.Common;
using Airport.Data.Flight;
using Airport.Domain.AirlineCompany;
using Airport.Domain.Common;
using Airport.Domain.Flight;
using Airport.Facade.Flight;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.Flight
{
    public abstract class FlightsPage : CommonPage<IFlightsRepository, Domain.Flight.Flight, FlightView, FlightData>
    {
        protected internal FlightsPage(IFlightsRepository r, IAirlineCompaniesRepository t) : base(r)
        {
            PageTitle = "FlightId";
            Companies = CreateSelectList<Domain.AirlineCompany.AirlineCompany, AirlineCompanyData>(t);
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Flight/FlightId";

        public override Domain.Flight.Flight ToObject(FlightView view) => FlightViewFactory.Create(view);
        public override FlightView ToView(Domain.Flight.Flight obj) => FlightViewFactory.Create(obj);
        public IEnumerable<SelectListItem> Companies { get; }

        protected new static IEnumerable<SelectListItem> CreateSelectList<TTDomain, TTData>(IRepository<TTDomain> r)
            where TTDomain : Entity<TTData>
            where TTData : UniqueEntityData, new()
        {
            var items = r.Get().GetAwaiter().GetResult();

            return items.Select(t => new SelectListItem(t.Data.Id, t.Data.Id)).ToList();
        }
    }
}
