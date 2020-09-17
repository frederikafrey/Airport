using System;
using System.Collections.Generic;
using System.Text;
using Airport.Data.Passenger;
using Airport.Data.PassengersFlight;
using Airport.Domain.Passenger;
using Airport.Domain.PassengersFlight;
using Airport.Facade.Passenger;
using Airport.Facade.PassengersFlight;

namespace Airport.Pages.PassengersFlight
{
    public abstract class PassengersFlightsPage : CommonPage<IPassengersFlightsRepository, Domain.PassengersFlight.PassengersFlight, PassengersFlightsView, PassengersFlightData>
    {
        protected internal PassengersFlightsPage(IPassengersFlightsRepository r) : base(r)
        {
            PageTitle = "Passengers Flight";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/PassengersFlight";

        protected internal override Domain.PassengersFlight.PassengersFlight ToObject(PassengersFlightsView view) => PassengersFlightsViewFactory.Create(view);
        protected internal override PassengersFlightsView ToView(Domain.PassengersFlight.PassengersFlight obj) => PassengersFlightsViewFactory.Create(obj);
    }
}
