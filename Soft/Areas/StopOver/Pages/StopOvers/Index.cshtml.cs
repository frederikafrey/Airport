using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.StopOver;
using Airport.Pages.StopOver;

namespace Airport.Soft.Areas.StopOver.Pages.StopOvers
{
    public class IndexModel : StopOversPage
    {
        public IndexModel(IStopOversRepository r, IFlightsRepository p, IFlightOfPassengersRepository t) : base(r, p, t) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
            => await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
    }
}
