using System;
using System.Collections.Generic;
using System.Text;
using Airport.Data.Luggage;
using Airport.Data.Passenger;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Facade.Luggage;
using Airport.Facade.Passenger;

namespace Airport.Pages.Passenger
{
    public abstract class PassengersPage : CommonPage<IPassengersRepository, Domain.Passenger.Passenger, PassengersView, PassengerData>
    {
        protected internal PassengersPage(IPassengersRepository r) : base(r)
        {
            PageTitle = "Passenger";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/Passenger";

        protected internal override Domain.Passenger.Passenger ToObject(PassengersView view) => PassengersViewFactory.Create(view);
        protected internal override PassengersView ToView(Domain.Passenger.Passenger obj) => PassengersViewFactory.Create(obj);
    }
}
