using Airport.Data.Flight;
using Airport.Domain.Flight;
using Airport.Facade.Flight;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Airport.Domain.Api.ApiCity;
using Airport.Domain.StopOver;
using Airport.Domain.Api.ApiCountry;

namespace Airport.Pages.Flight
{
    public abstract class FlightsPage : CommonPage<IFlightsRepository, Domain.Flight.Flight, FlightView, FlightData>
    {
        protected internal FlightsPage(IFlightsRepository r, IApiCountriesRepository c, IApiCitiesRepository p, IStopOversRepository s) : base(r)
        {
            PageTitle = "Flights";
            Countries = CreateSelectList(c);
            Cities = new List<SelectListItem>();
            StopOvers = CreateSelectListStopOver(s);
        }

        public IEnumerable<SelectListItem> Countries { get; }
        public IEnumerable<SelectListItem> Cities { get; }
        public IEnumerable<SelectListItem> StopOvers { get; }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Flight/Flights";

        public override Domain.Flight.Flight ToObject(FlightView view) => FlightViewFactory.Create(view);
        public override FlightView ToView(Domain.Flight.Flight obj) => FlightViewFactory.Create(obj);
     
    }
}
