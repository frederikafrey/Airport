﻿using Airport.Data.PassengersFlight;
using Airport.Domain.PassengersFlight;
using Airport.Facade.PassengersFlight;

namespace Airport.Pages.PassengersFlight
{
    public abstract class PassengersFlightsPage : CommonPage<IPassengersFlightsRepository, Domain.PassengersFlight.PassengersFlight, PassengersFlightView, PassengersFlightData>
    {
        protected internal PassengersFlightsPage(IPassengersFlightsRepository r) : base(r)
        {
            PageTitle = "Passengers Flight";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/PassengersFlight";

        protected internal override Domain.PassengersFlight.PassengersFlight ToObject(PassengersFlightView view) => PassengersFlightViewFactory.Create(view);
        protected internal override PassengersFlightView ToView(Domain.PassengersFlight.PassengersFlight obj) => PassengersFlightViewFactory.Create(obj);
    }
}
