using System.Collections.Generic;
using System.Linq;
using Airport.Data.Common;
using Airport.Domain.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages
{
    public abstract class CommonPage<TRepository, TDomain, TView, TData> : 
        PaginatedPage<TRepository, TDomain, TView, TData>
        where TRepository : ICrudMethods<TDomain>, ISorting, IFiltering, IPaging
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

        protected static IEnumerable<SelectListItem> CreateSelectList2<TTDomain, TTData>(IRepository<TTDomain> r)
            where TTDomain : Entity<TTData>
            where TTData : UniqueEntityData, new()
        {
            var items = r.Get().GetAwaiter().GetResult();

            return items.Select(m => new SelectListItem(m.Data.Id, m.Data.Id)).ToList();
        }
        protected static IEnumerable<SelectListItem> CreateSelectList<TTDomain, TTData>(IRepository<TTDomain> r)
            where TTDomain : Entity<TTData>
            where TTData : UniqueEntityData, new()
        {
            var items = r.Get().GetAwaiter().GetResult();

            return items.Select(m => new SelectListItem(m.Data.Id, m.Data.Id)).ToList();
        }
    }
}
