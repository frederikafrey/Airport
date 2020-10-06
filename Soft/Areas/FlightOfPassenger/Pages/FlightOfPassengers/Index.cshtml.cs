using System.Threading.Tasks;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Passenger;
using Airport.Domain.StopOver;
using Airport.Pages.FlightOfPassenger;

namespace Airport.Soft.Areas.FlightOfPassenger.Pages.FlightOfPassengers
{
    public class IndexModel : FlightOfPassengersPage
    {
        public IndexModel(IFlightOfPassengersRepository r, IStopOversRepository p, IPassengersRepository t) : base(r, p, t) { }

        public async Task OnGetAsync(string sortOrder, string id, string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }

        public override string ItemId { get; }
    }
}
