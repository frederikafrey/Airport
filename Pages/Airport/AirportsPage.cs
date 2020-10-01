using System.Collections.Generic;
using Airport.Data.Airport;
using Airport.Domain.Airport;
using Airport.Facade.Airport;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.Airport
{
    public abstract class AirportsPage : CommonPage<IAirportsRepository, Domain.Airport.Airport, AirportView, AirportData>
    {
        protected internal AirportsPage(IAirportsRepository r) : base(r) => PageTitle = "Airports";

        public override string ItemId => Item?.Id ?? string.Empty;

        public override string GetPageUrl() => "/Airport/Airports";

        public override Domain.Airport.Airport ToObject(AirportView view) => AirportViewFactory.Create(view);

        public override AirportView ToView(Domain.Airport.Airport obj) => AirportViewFactory.Create(obj);
    }
}
