using Airport.Data.PassengersFlight;
using Airport.Domain.PassengersFlight;
using Airport.Facade.PassengersFlight;

namespace Airport.Pages.PassengersFlight
{
    public abstract class PassengersFlightsPage : CommonPage<IPassengersFlightsRepository, Domain.PassengersFlight.PassengersFlight, PassengerFlightView, PassengersFlightData>
    {
        protected internal PassengersFlightsPage(IPassengersFlightsRepository r) : base(r)
        {
            PageTitle = "Passengers Flight";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/PassengersFlight";

        protected internal override Domain.PassengersFlight.PassengersFlight ToObject(PassengerFlightView view) => PassengerFlightViewFactory.Create(view);
        protected internal override PassengerFlightView ToView(Domain.PassengersFlight.PassengersFlight obj) => PassengerFlightViewFactory.Create(obj);
    }
}
