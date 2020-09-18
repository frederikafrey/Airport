using Airport.Data.AirportsFlight;
using Airport.Domain.AirportsFlight;
using Airport.Facade.AirportsFlight;

namespace Airport.Pages.AirportsFlight
{
    public abstract class AirportsFlightPage : CommonPage<IAirportsFlightsRepository, Domain.AirportsFlight.AirportsFlight, AirportsFlightView, AirportsFlightData>
    {
        protected internal AirportsFlightPage(IAirportsFlightsRepository r) : base(r)
        {
            PageTitle = "Airport Flight";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Airport/AirportsFlight";

        public override Domain.AirportsFlight.AirportsFlight ToObject(AirportsFlightView view) => AirportsFlightViewFactory.Create(view);
        protected internal override AirportsFlightView ToView(Domain.AirportsFlight.AirportsFlight obj) => AirportsFlightViewFactory.Create(obj);
    }
}
