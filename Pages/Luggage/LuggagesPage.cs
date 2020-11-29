using System.Collections.Generic;
using Airport.Data.Luggage;
using Airport.Domain.Luggage;
using Airport.Facade.Luggage;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.Luggage
{
    public abstract class LuggagesPage : CommonPage<ILuggagesRepository, Domain.Luggage.Luggage, LuggageView, LuggageData>
    {
        protected internal LuggagesPage(ILuggagesRepository r) : base(r)
        {
            PageTitle = "Luggage";
        }
        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Luggage/Luggages";

        public override Domain.Luggage.Luggage ToObject(LuggageView view) => LuggageViewFactory.Create(view);
        public override LuggageView ToView(Domain.Luggage.Luggage obj) => LuggageViewFactory.Create(obj);
    }
}
