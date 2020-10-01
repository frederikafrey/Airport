using Airport.Data.FlightOfPassenger;
using Airport.Domain.FlightOfPassenger;
using Airport.Facade.FlightOfPassenger;

namespace Airport.Pages.FlightOfPassenger
{
    public abstract class FlightOfPassengersPage : CommonPage<IFlightOfPassengersRepository, Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerView, FlightOfPassengerData>
    {
        protected internal FlightOfPassengersPage(IFlightOfPassengersRepository r) : base(r)
        {
            PageTitle = "Flight Of Passengers";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/FlightOfPassenger/FlightOfPassengerId";

        public override Domain.FlightOfPassenger.FlightOfPassenger ToObject(FlightOfPassengerView ofPassengerView) => FlightOfPassengerViewFactory.Create(ofPassengerView);
        public override FlightOfPassengerView ToView(Domain.FlightOfPassenger.FlightOfPassenger obj) => FlightOfPassengerViewFactory.Create(obj);
    }
}
