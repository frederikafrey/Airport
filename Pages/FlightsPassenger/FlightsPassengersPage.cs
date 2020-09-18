using Airport.Data.FlightsPassenger;
using Airport.Domain.FlightsPassenger;
using Airport.Facade.FlightsPassenger;

namespace Airport.Pages.FlightsPassenger
{
    public abstract class FlightsPassengerPage : CommonPage<IFlightsPassengersRepository, Domain.FlightsPassenger.FlightsPassenger, FlightsPassengerView, FlightsPassengerData>
    {
        protected internal FlightsPassengerPage(IFlightsPassengersRepository r) : base(r)
        {
            PageTitle = "Flights Passenger";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/FlightsPassenger";

        protected internal override Domain.FlightsPassenger.FlightsPassenger ToObject(FlightsPassengerView view) => FlightsPassengerViewFactory.Create(view);
        protected internal override FlightsPassengerView ToView(Domain.FlightsPassenger.FlightsPassenger obj) => FlightsPassengerViewFactory.Create(obj);
    }
}
