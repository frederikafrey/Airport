using System.Collections.Generic;
using System.Linq;
using Airport.Data.Common;
using Airport.Domain.Api.ApiCarrier;
using Airport.Domain.Api.ApiCity;
using Airport.Domain.Api.ApiCountry;
using Airport.Domain.Common;
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
        protected static IEnumerable<SelectListItem> CreateSelectList<TTDomain, TTData>(IRepository<TTDomain> r)
            where TTDomain : Entity<TTData>
            where TTData : UniqueEntityData, new()
        {
            var items = r.Get().GetAwaiter().GetResult();

            return items.Select(m => new SelectListItem(m.Data.Id, m.Data.Id)).ToList();
        }
        protected static IEnumerable<SelectListItem> CreateSelectListStopOver(IStopOversRepository s)
        {
            var items = s.Get().GetAwaiter().GetResult();

            return items.Select(m => new SelectListItem(m.Data.City, m.Data.Id)).ToList();
        }

        protected static IEnumerable<SelectListItem> CreateSelectList(IStopOversRepository s)
        {
            var items = s.Get().GetAwaiter().GetResult();

            return items.Select(m => new SelectListItem(m.Data.City, m.Data.Id)).ToList();
        }

        //public static List<SelectListItem> Dimensions = new List<SelectListItem>()
        //{
        //    new SelectListItem() {Text="Alabama", Value="AL"},
        //    new SelectListItem() { Text="Alaska", Value="AK"},
        //    new SelectListItem() { Text="Arizona", Value="AZ"},
        //    new SelectListItem() { Text="Arkansas", Value="AR"},

        //};
    }
}
