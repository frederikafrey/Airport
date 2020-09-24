using Airport.Data.Flight;
using Airport.Domain.AirlinesCompany;
using Airport.Domain.Flight;
using Airport.Facade.Flight;

namespace Airport.Pages.Flight
{
    public abstract class FlightsPage : CommonPage<IFlightsRepository, Domain.Flight.Flight, FlightView, FlightData>
    {
        protected internal FlightsPage(IFlightsRepository r, IAirlinesCompaniesRepository t) : base(r)
        {
            PageTitle = "Flights";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        public override string GetPageUrl() => "/Flight/Flights";

        public override Domain.Flight.Flight ToObject(FlightView view) => FlightViewFactory.Create(view);
        public override FlightView ToView(Domain.Flight.Flight obj) => FlightViewFactory.Create(obj);
    }
}
