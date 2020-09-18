using Airport.Data.Airport;
using Airport.Domain.Airport;
using Airport.Facade.Airport;

namespace Airport.Pages.Airport
{
    public abstract class AirportsPage : CommonPage<IAirportsRepository, Domain.Airport.Airport, AirportView, AirportData>
    {
        protected internal AirportsPage(IAirportsRepository r) : base(r)
        {
            PageTitle = "Airport";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string GetPageUrl() => "/Airport/Airport";

        protected internal override Domain.Airport.Airport ToObject(AirportView view) => AirportViewFactory.Create(view);
        protected internal override AirportView ToView(Domain.Airport.Airport obj) => AirportViewFactory.Create(obj);
    }
}
