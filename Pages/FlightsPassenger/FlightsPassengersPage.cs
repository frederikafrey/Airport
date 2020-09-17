using System;
using System.Collections.Generic;
using System.Text;
using Airport.Data.Flight;
using Airport.Data.FlightsPassenger;
using Airport.Domain.Flight;
using Airport.Domain.FlightsPassenger;
using Airport.Facade.Flight;
using Airport.Facade.FlightsPassenger;

namespace Airport.Pages.FlightsPassenger
{
    public abstract class FlightsPassengerPage : CommonPage<IFlightsPassengersRepository, Domain.FlightsPassenger.FlightsPassenger, FlightsPassengersView, FlightsPassengerData>
    {
        protected internal FlightsPassengerPage(IFlightsPassengersRepository r) : base(r)
        {
            PageTitle = "Flights Passenger";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/FlightsPassenger";

        protected internal override Domain.FlightsPassenger.FlightsPassenger ToObject(FlightsPassengersView view) => FlightsPassengersViewFactory.Create(view);
        protected internal override FlightsPassengersView ToView(Domain.FlightsPassenger.FlightsPassenger obj) => FlightsPassengersViewFactory.Create(obj);
    }
}
