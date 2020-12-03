using System.Collections.Generic;
using Airport.Data.FlightOfPassenger;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Facade.FlightOfPassenger;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Pages.FlightOfPassenger
{
    public abstract class FlightOfPassengersPage : CommonPage<IFlightOfPassengersRepository, Domain.FlightOfPassenger.FlightOfPassenger, FlightOfPassengerView, FlightOfPassengerData>
    {
        protected internal FlightOfPassengersPage(IFlightOfPassengersRepository r, IPassengersRepository p, IFlightsRepository f, ILuggagesRepository l) : base(r)
        {
            PageTitle = "Flight Of Passengers";
            Passengers = CreateSelectListPassengers(p);
            Flights = CreateSelectListFlights(f);
            Luggage = CreateSelectListLuggage(l);
        }
        public IEnumerable<SelectListItem> Passengers { get; }
        public IEnumerable<SelectListItem> Flights { get; }
        public IEnumerable<SelectListItem> Luggage { get; }

        public override string ItemId => Item is null ? string.Empty : Item.GetId();
        public override string GetPageUrl() => "/FlightOfPassenger/FlightOfPassengers";

        public override Domain.FlightOfPassenger.FlightOfPassenger ToObject(FlightOfPassengerView view)
            => FlightOfPassengerViewFactory.Create(view);

        public override FlightOfPassengerView ToView(Domain.FlightOfPassenger.FlightOfPassenger obj)
            => FlightOfPassengerViewFactory.Create(obj);
    }
}
