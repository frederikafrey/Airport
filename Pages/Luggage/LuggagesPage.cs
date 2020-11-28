using System.Collections.Generic;
using System.Linq;
using Airport.Aids;
using Airport.Data.Common;
using Airport.Data.FlightOfPassenger;
using Airport.Data.Luggage;
using Airport.Domain.Common;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Luggage;
using Airport.Facade.Luggage;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.Luggage
{
    public abstract class LuggagesPage : CommonPage<ILuggagesRepository, Domain.Luggage.Luggage, LuggageView, LuggageData>
    {
        protected internal LuggagesPage(ILuggagesRepository r, IFlightOfPassengersRepository p) : base(r)
        {
            PageTitle = "Luggage";
            Dimensions = new List<SelectListItem>();
        }
        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Luggage/Luggages";

        public override Domain.Luggage.Luggage ToObject(LuggageView view) => LuggageViewFactory.Create(view);
        public override LuggageView ToView(Domain.Luggage.Luggage obj) => LuggageViewFactory.Create(obj);
        //protected new static IEnumerable<SelectListItem> CreateSelectList<TTDomain, TTData>(IRepository<TTDomain> r)
        //    where TTDomain : Entity<TTData>
        //    where TTData : UniqueEntityData, new()
        //{
        //    var items = r.Get().GetAwaiter().GetResult();

        //    return items.Select(t => new SelectListItem(t.Data.Id, t.Data.Id)).ToList();
        //}

        public static List<SelectListItem> Dimensions = new List<SelectListItem>()
        {
            new SelectListItem() {Text="Alabama", Value="AL"},
            new SelectListItem() { Text="Alaska", Value="AK"},
            new SelectListItem() { Text="Arizona", Value="AZ"},
            new SelectListItem() { Text="Arkansas", Value="AR"},

        };
    }
}
