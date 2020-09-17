using Airport.Data.Luggage;
using Airport.Domain.Luggage;
using Airport.Facade.Luggage;

namespace Airport.Pages.Luggage
{
    public abstract class LuggagesPage : CommonPage<ILuggagesRepository, Domain.Luggage.Luggage, LuggagesView, LuggageData>
    {
        protected internal LuggagesPage(ILuggagesRepository r) : base(r)
        {
            PageTitle = "Luggage";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/Luggage";

        protected internal override Domain.Luggage.Luggage ToObject(LuggagesView view) => LuggagesViewFactory.Create(view);
        protected internal override LuggagesView ToView(Domain.Luggage.Luggage obj) => LuggagesViewFactory.Create(obj);
    }
}
