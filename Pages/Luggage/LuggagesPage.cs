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
        public override string GetPageUrl() => "/Airport/Luggage";

        public override Domain.Luggage.Luggage ToObject(LuggageView view) => LuggageViewFactory.Create(view);
        public override LuggageView ToView(Domain.Luggage.Luggage obj) => LuggageViewFactory.Create(obj);
    }
}
