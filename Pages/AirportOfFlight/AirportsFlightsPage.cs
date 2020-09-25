using Airport.Data.AirportOfFlight;
using Airport.Domain.AirportOfFlight;
using Airport.Facade.AirportOfFlight;

namespace Airport.Pages.AirportOfFlight
{
    public abstract class AirportOfFlightPage : CommonPage<IAirportOfFlightsRepository, Domain.AirportOfFlight.AirportOfFlight, AirportOfFlightView, AirportOfFlightData>
    {
        protected internal AirportOfFlightPage(IAirportOfFlightsRepository r) : base(r)
        {
            PageTitle = "Airport Of Flights";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/AirportOfFlight/AirportOfFlights";

        public override Domain.AirportOfFlight.AirportOfFlight ToObject(AirportOfFlightView view) => AirportOfFlightViewFactory.Create(view);
        public override AirportOfFlightView ToView(Domain.AirportOfFlight.AirportOfFlight obj) => AirportOfFlightViewFactory.Create(obj);
    }
}
