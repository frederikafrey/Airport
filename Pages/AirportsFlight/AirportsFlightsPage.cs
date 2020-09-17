using System;
using System.Collections.Generic;
using System.Text;
using Airport.Data.AirlinesCompany;
using Airport.Data.AirportsFlight;
using Airport.Domain.AirlinesCompany;
using Airport.Domain.AirportsFlight;
using Airport.Facade.AirlinesCompany;
using Airport.Facade.AirportsFlight;

namespace Airport.Pages.AirportsFlight
{
    public abstract class AirportsFlightPage : CommonPage<IAirportsFlightsRepository, Domain.AirportsFlight.AirportsFlight, AirportsFlightsView, AirportsFlightData>
    {
        protected internal AirportsFlightPage(IAirportsFlightsRepository r) : base(r)
        {
            PageTitle = "Airport Flight";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/AirportsFlight";

        protected internal override Domain.AirportsFlight.AirportsFlight ToObject(AirportsFlightsView view) => AirportsFlightsViewFactory.Create(view);
        protected internal override AirportsFlightsView ToView(Domain.AirportsFlight.AirportsFlight obj) => AirportsFlightsViewFactory.Create(obj);
    }
}
