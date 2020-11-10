using Airport.Data.Flight;
using Airport.Domain.Api;
using Airport.Domain.Flight;
using Airport.Facade.Flight;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Airport.Data.Api.ApiCity;

namespace Airport.Pages.Flight
{
    public abstract class FlightsPage : CommonPage<IFlightsRepository, Domain.Flight.Flight, FlightView, FlightData>
    {
        protected internal FlightsPage(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p) : base(r)
            //IAirlineCompaniesRepository p, IAirportsRepository t
        {
            PageTitle = "Flights";
            Countries = CreateSelectList(c);
           
            // TODO If country selected
            Cities = CreateSelectList(p, Countries.ElementAt(105).Text);
            //CitiesReal = p.GetAll()
           
            //Airports = CreateSelectList2<Domain.Airport.Airport, AirportData>(t);
        }

        public IEnumerable<SelectListItem> Countries { get; }
        public IEnumerable<SelectListItem> Cities { get; }
        //TODO View??
        //public IEnumerable<ApiCityProperties> CitiesReal { get; }
        //public IEnumerable<SelectListItem> Airports { get; }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Flight/Flights";

        public override Domain.Flight.Flight ToObject(FlightView view) => FlightViewFactory.Create(view);
        public override FlightView ToView(Domain.Flight.Flight obj) => FlightViewFactory.Create(obj);

        protected static IEnumerable<SelectListItem> CreateSelectList(IApiCitiesRepository p, string name)
        {
            var items = p.GetAll(name).GetAwaiter().GetResult(); ;
            return items.Select(t => new SelectListItem(t.PlaceName, t.CityId)).ToList();
        }
    }
}
