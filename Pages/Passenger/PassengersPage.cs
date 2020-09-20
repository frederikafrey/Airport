using Airport.Data.Passenger;
using Airport.Domain.Passenger;
using Airport.Facade.Passenger;

namespace Airport.Pages.Passenger
{
    public abstract class PassengersPage : CommonPage<IPassengersRepository, Domain.Passenger.Passenger, PassengerView, PassengerData>
    {
        protected internal PassengersPage(IPassengersRepository r) : base(r)
        {
            PageTitle = "Passenger";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Airport/Passenger";

        public override Domain.Passenger.Passenger ToObject(PassengerView view) => PassengerViewFactory.Create(view);
        public override PassengerView ToView(Domain.Passenger.Passenger obj) => PassengerViewFactory.Create(obj);
    }
}
