using System.Collections.Generic;
using System.Linq;
using Airport.Data.AirlineCompany;
using Airport.Data.Airport;
using Airport.Data.Common;
using Airport.Data.Flight;
using Airport.Domain.AirlineCompany;
using Airport.Domain.Airport;
using Airport.Domain.Common;
using Airport.Domain.Flight;
using Airport.Facade.Flight;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.Flight
{
    public abstract class FlightsPage : CommonPage<IFlightsRepository, Domain.Flight.Flight, FlightView, FlightData>
    {
        protected internal FlightsPage(IFlightsRepository r, IAirlineCompaniesRepository p, IAirportsRepository t) : base(r)
        {
            PageTitle = "Flights";
            AirlineCompanies = CreateSelectList<Domain.AirlineCompany.AirlineCompany, AirlineCompanyData>(p);
            Airports = CreateSelectList<Domain.Airport.Airport, AirportData>(t);
        }

        public IEnumerable<SelectListItem> AirlineCompanies { get; }
        public IEnumerable<SelectListItem> Airports { get; }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Flight/Flights";

        public override Domain.Flight.Flight ToObject(FlightView view) => FlightViewFactory.Create(view);
        public override FlightView ToView(Domain.Flight.Flight obj) => FlightViewFactory.Create(obj);

        protected new static IEnumerable<SelectListItem> CreateSelectList<TTDomain, TTData>(IRepository<TTDomain> r)
            where TTDomain : Entity<TTData>
            where TTData : UniqueEntityData, new()
        {
            var items = r.Get().GetAwaiter().GetResult();

            return items.Select(t => new SelectListItem(t.Data.Id, t.Data.Id)).ToList();
        }
    }
}
