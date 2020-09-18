using Airport.Data.Flight;
using Airport.Domain.Flight;
using Airport.Facade.Flight;

namespace Airport.Pages.Flight
{
    public abstract class FlightsPage : CommonPage<IFlightsRepository, Domain.Flight.Flight, FlightView, FlightData>
    {
        protected internal FlightsPage(IFlightsRepository r) : base(r)
        {
            PageTitle = "Flight";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/Flight";

        protected internal override Domain.Flight.Flight ToObject(FlightView view) => FlightViewFactory.Create(view);
        protected internal override FlightView ToView(Domain.Flight.Flight obj) => FlightViewFactory.Create(obj);
    }
}
