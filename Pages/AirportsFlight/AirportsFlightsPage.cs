using Airport.Data.AirportsFlight;
using Airport.Domain.AirportsFlight;
using Airport.Facade.AirportsFlight;

namespace Airport.Pages.AirportsFlight
{
    public abstract class AirportsFlightPage : CommonPage<IAirportsFlightsRepository, Domain.AirportsFlight.AirportsFlight, AirportFlightView, AirportsFlightData>
    {
        protected internal AirportsFlightPage(IAirportsFlightsRepository r) : base(r)
        {
            PageTitle = "Airport Flight";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/AirportsFlight";

        protected internal override Domain.AirportsFlight.AirportsFlight ToObject(AirportFlightView view) => AirportFlightViewFactory.Create(view);
        protected internal override AirportFlightView ToView(Domain.AirportsFlight.AirportsFlight obj) => AirportFlightViewFactory.Create(obj);
    }
}
