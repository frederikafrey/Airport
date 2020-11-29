using System.Collections.Generic;
using System.Linq;
using Airport.Data.Common;
using Airport.Domain.Api.ApiCarrier;
using Airport.Domain.Api.ApiCity;
using Airport.Domain.Api.ApiCountry;
using Airport.Domain.Common;
using Airport.Domain.Flight;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Domain.StopOver;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages
{
    public abstract class CommonPage<TRepository, TDomain, TView, TData> : 
        PaginatedPage<TRepository, TDomain, TView, TData> where TRepository : ICrudMethods<TDomain>, ISorting, IFiltering, IPaging
    {

        protected internal CommonPage(TRepository r) : base(r) { }

        public abstract string ItemId { get; }

        public string PageTitle { get; set; }

        public string PageUrl => GetPageUrl();

        public abstract string GetPageUrl();

        public string IndexUrl => GetIndexUrl();

        public string GetIndexUrl() => $"{PageUrl}/Index?fixedFilter={FixedFilter}&fixedValue={FixedValue}";
        
        public string PageSubTitle => GetPageSubTitle();

        public virtual string GetPageSubTitle() => string.Empty;

        protected static IEnumerable<SelectListItem> CreateSelectList(IApiCountriesRepository c)
        {
            var items = c.GetAll().GetAwaiter().GetResult(); ;
            return items.Select(t => new SelectListItem(t.Name, t.Name)).ToList();
        }
        protected static IEnumerable<SelectListItem> CreateSelectList(IApiCarriersRepository c)
        {
            var items = c.GetAll().GetAwaiter().GetResult(); ;
            return items.Select(t => new SelectListItem(t.Name, t.Name)).ToList();
        }

        protected static IEnumerable<SelectListItem> CreateSelectList(IApiCitiesRepository p, string name)
        {
            var items = p.GetAll(name).GetAwaiter().GetResult(); 
            return items.Select(t => new SelectListItem(t.PlaceName, t.CityId)).ToList();
        }
       
        protected static IEnumerable<SelectListItem> CreateSelectListStopOver(IStopOversRepository s)
        {
            var items = s.Get().GetAwaiter().GetResult();

            return items.Select(m => new SelectListItem(m.Data.City, m.Data.Id)).ToList();
        }

        protected static IEnumerable<SelectListItem> CreateSelectListLuggage(ILuggagesRepository l)
        {
            var items = l.Get().GetAwaiter().GetResult();

            return items.Select(m => new SelectListItem(m.Data.Weight, m.Data.Dimensions)).ToList();
        }
        protected static IEnumerable<SelectListItem> CreateSelectListPassengers(IPassengersRepository p)
        {
            var items = p.Get().GetAwaiter().GetResult();

            return items.Select(m => new SelectListItem(m.Data.Name, m.Data.Name)).ToList();
        }
        protected static IEnumerable<SelectListItem> CreateSelectListFlights(IFlightsRepository f)
        {
            var items = f.Get().GetAwaiter().GetResult();

            return items.Select(m => new SelectListItem(m.Data.Plane, m.Data.Plane)).ToList();
        }
    }
}
