using Airport.Data.Airport;
using Airport.Domain.Airport;
using Airport.Facade.Airport;

namespace Airport.Pages.Airport
{
    public abstract class AirportsPage : CommonPage<IAirportsRepository, Domain.Airport.Airport, AirportsView, AirportData>
    {
        protected internal AirportsPage(IAirportsRepository r) : base(r)
        {
            PageTitle = "Airport";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/Airport";

        protected internal override Domain.Airport.Airport ToObject(AirportsView view) => AirportsViewFactory.Create(view);
        protected internal override AirportsView ToView(Domain.Airport.Airport obj) => AirportsViewFactory.Create(obj);
    }
}
