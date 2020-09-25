using System.Threading.Tasks;
using Airport.Domain.FlightOfPassenger;
using Airport.Pages.FlightOfPassenger;

namespace Airport.Soft.Areas.FlightOfPassenger.Pages.FlightOfPassengers
{
    public class IndexModel : FlightOfPassengersPage
    {
        public IndexModel(IFlightOfPassengersRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string id, string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}
