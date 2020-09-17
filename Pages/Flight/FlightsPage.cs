using Airport.Data.Flight;
using Airport.Domain.Flight;
using Airport.Facade.Flight;

namespace Airport.Pages.Flight
{
    public abstract class FlightsPage : CommonPage<IFlightsRepository, Domain.Flight.Flight, FlightsView, FlightData>
    {
        protected internal FlightsPage(IFlightsRepository r) : base(r)
        {
            PageTitle = "Flight";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/Flight";

        protected internal override Domain.Flight.Flight ToObject(FlightsView view) => FlightsViewFactory.Create(view);
        protected internal override FlightsView ToView(Domain.Flight.Flight obj) => FlightsViewFactory.Create(obj);
    }
}
