using System.Collections.Generic;
using Airport.Data.Luggage;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Facade.Luggage;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.Luggage
{
    public abstract class LuggagesPage : CommonPage<ILuggagesRepository, Domain.Luggage.Luggage, LuggageView, LuggageData>
    {
        protected internal LuggagesPage(ILuggagesRepository l, IPassengersRepository p) : base(l)
        {
            PageTitle = "Luggage";
            Passengers = CreateSelectListPassengers(p);
            Dimensions = CreateSelectListDimensions(l);
            Weight = CreateSelectListWeights(l);

        }
        public IEnumerable<SelectListItem> Dimensions { get; }
        public IEnumerable<SelectListItem> Weight { get; }
        public IEnumerable<SelectListItem> Passengers { get; }
        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Luggage/Luggages";

        public override Domain.Luggage.Luggage ToObject(LuggageView view) => LuggageViewFactory.Create(view);
        public override LuggageView ToView(Domain.Luggage.Luggage obj) => LuggageViewFactory.Create(obj);
    }
}
