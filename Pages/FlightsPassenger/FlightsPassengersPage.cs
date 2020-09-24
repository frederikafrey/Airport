using System.Collections.Generic;
using Airport.Data.Flight;
using Airport.Data.FlightsPassenger;
using Airport.Data.Passenger;
using Airport.Data.PassengersFlight;
using Airport.Domain.Flight;
using Airport.Domain.FlightsPassenger;
using Airport.Domain.Passenger;
using Airport.Domain.PassengersFlight;
using Airport.Facade.FlightsPassenger;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.FlightsPassenger
{
    public abstract class FlightsPassengerPage : CommonPage<IFlightsPassengersRepository, Domain.FlightsPassenger.FlightsPassenger, FlightsPassengerView, FlightsPassengerData>
    {
        protected internal FlightsPassengerPage(IFlightsPassengersRepository r, IFlightsRepository c, IPassengersFlightsRepository t) : base(r)
        {
            PageTitle = "Flight Passengers";
            FlightId = CreateSelectList2<Domain.Flight.Flight, FlightData>(c);
            PassengersFlightId = CreateSelectList<Domain.PassengersFlight.PassengersFlight, PassengersFlightData>(t);
        }
        public IEnumerable<SelectListItem> FlightId { get; }
        public IEnumerable<SelectListItem> PassengersFlightId { get; }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/FlightsPassenger/FlightsPassengers";

        public override Domain.FlightsPassenger.FlightsPassenger ToObject(FlightsPassengerView view) => FlightsPassengerViewFactory.Create(view);
        public override FlightsPassengerView ToView(Domain.FlightsPassenger.FlightsPassenger obj) => FlightsPassengerViewFactory.Create(obj);
    }
}
