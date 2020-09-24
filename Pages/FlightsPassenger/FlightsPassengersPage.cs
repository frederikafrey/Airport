using Airport.Data.FlightsPassenger;
using Airport.Domain.Flight;
using Airport.Domain.FlightsPassenger;
using Airport.Domain.Passenger;
using Airport.Facade.FlightsPassenger;

namespace Airport.Pages.FlightsPassenger
{
    public abstract class FlightsPassengerPage : CommonPage<IFlightsPassengersRepository, Domain.FlightsPassenger.FlightsPassenger, FlightsPassengerView, FlightsPassengerData>
    {
        protected internal FlightsPassengerPage(IFlightsPassengersRepository r, IFlightsRepository c, IPassengersRepository t) : base(r)
        {
            PageTitle = "Flights Passengers";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/FlightsPassenger/FlightsPassengers";

        public override Domain.FlightsPassenger.FlightsPassenger ToObject(FlightsPassengerView view) => FlightsPassengerViewFactory.Create(view);
        public override FlightsPassengerView ToView(Domain.FlightsPassenger.FlightsPassenger obj) => FlightsPassengerViewFactory.Create(obj);
    }
}
