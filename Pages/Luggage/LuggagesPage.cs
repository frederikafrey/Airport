using System.Collections.Generic;
using System.Linq;
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
            FlightOfPassengers = CreateSelectList<Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerData>(p);
        }

        public IEnumerable<SelectListItem> FlightOfPassengers { get; }
        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Luggage/Luggages";

        public override Domain.Luggage.Luggage ToObject(LuggageView view) => LuggageViewFactory.Create(view);
        public override LuggageView ToView(Domain.Luggage.Luggage obj) => LuggageViewFactory.Create(obj);
        protected new static IEnumerable<SelectListItem> CreateSelectList<TTDomain, TTData>(IRepository<TTDomain> r)
            where TTDomain : Entity<TTData>
            where TTData : UniqueEntityData, new()
        {
            var items = r.Get().GetAwaiter().GetResult();

            return items.Select(t => new SelectListItem(t.Data.Id, t.Data.Id)).ToList();
        }
    }
}
