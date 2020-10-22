using System.Collections.Generic;
using System.Linq;
using Airport.Data.Api;
using Airport.Data.Api.ApiPlace;
using Airport.Data.Common;
using Airport.Data.Flight;
using Airport.Domain.Api;
using Airport.Domain.Common;
using Airport.Domain.Flight;
using Airport.Facade.Flight;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.Flight
{
    public abstract class FlightsPage : CommonPage<IFlightsRepository, Domain.Flight.Flight, FlightView, FlightData>
    {
        protected internal FlightsPage(IFlightsRepository r, IApiPlacesRepository p) : base(r)
            //IAirlineCompaniesRepository p, IAirportsRepository t
        {
            PageTitle = "Flights";
            Names = CreateSelectList<Domain.Api.IApiPlacesRepository, ApiPlaceData>(p);
            //Airports = CreateSelectList2<Domain.Airport.Airport, AirportData>(t);
        }

        public IEnumerable<SelectListItem> Names { get; }
        //public IEnumerable<SelectListItem> Airports { get; }

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
        protected new static IEnumerable<SelectListItem> CreateSelectList2<TTDomain, TTData>(IRepository<TTDomain> r)
            where TTDomain : Entity<TTData>
            where TTData : UniqueEntityData, new()
        {
            var items = r.Get().GetAwaiter().GetResult();

            return items.Select(t => new SelectListItem(t.Data.Id, t.Data.Id)).ToList();
        }
    }
}
