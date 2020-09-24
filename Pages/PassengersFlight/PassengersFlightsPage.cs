using Airport.Data.PassengersFlight;
using Airport.Domain.PassengersFlight;
using Airport.Facade.PassengersFlight;

namespace Airport.Pages.PassengersFlight
{
    public abstract class PassengersFlightsPage : CommonPage<IPassengersFlightsRepository, Domain.PassengersFlight.PassengersFlight, PassengersFlightView, PassengersFlightData>
    {
        protected internal PassengersFlightsPage(IPassengersFlightsRepository r) : base(r)
        {
            PageTitle = "Passenger Flights";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/PassengersFlight/PassengersFlights";

        public override Domain.PassengersFlight.PassengersFlight ToObject(PassengersFlightView view) => PassengersFlightViewFactory.Create(view);
        public override PassengersFlightView ToView(Domain.PassengersFlight.PassengersFlight obj) => PassengersFlightViewFactory.Create(obj);
    }
}
