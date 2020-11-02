using Airport.Data.Api.ApiCountry;
using Airport.Data.Flight;
using Airport.Domain.Api;
using Airport.Domain.Flight;
using Airport.Facade.Flight;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Airport.Data.Api.ApiCity;

namespace Airport.Pages.Flight
{
    public abstract class FlightsPage : CommonPage<IFlightsRepository, Domain.Flight.Flight, FlightView, FlightData>
    {
        protected internal FlightsPage(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p) : base(r)
            //IAirlineCompaniesRepository p, IAirportsRepository t
        {
            PageTitle = "Flights";
            Names = CreateSelectList(c);
            Cities = CreateSelectList(p);
            //Airports = CreateSelectList2<Domain.Airport.Airport, AirportData>(t);
        }

        public IEnumerable<SelectListItem> Names { get; }
        public IEnumerable<SelectListItem> Cities { get; }
        //public IEnumerable<SelectListItem> Airports { get; }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Flight/Flights";

        public override Domain.Flight.Flight ToObject(FlightView view) => FlightViewFactory.Create(view);
        public override FlightView ToView(Domain.Flight.Flight obj) => FlightViewFactory.Create(obj);
    }
}
