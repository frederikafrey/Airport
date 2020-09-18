using Airport.Data.Luggage;
using Airport.Domain.Luggage;
using Airport.Facade.Luggage;

namespace Airport.Pages.Luggage
{
    public abstract class LuggagesPage : CommonPage<ILuggagesRepository, Domain.Luggage.Luggage, LuggageView, LuggageData>
    {
        protected internal LuggagesPage(ILuggagesRepository r) : base(r)
        {
            PageTitle = "Luggage";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/Luggage";

        protected internal override Domain.Luggage.Luggage ToObject(LuggageView view) => LuggageViewFactory.Create(view);
        protected internal override LuggageView ToView(Domain.Luggage.Luggage obj) => LuggageViewFactory.Create(obj);
    }
}
