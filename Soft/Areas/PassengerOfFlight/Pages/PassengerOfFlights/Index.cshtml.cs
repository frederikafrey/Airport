using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.PassengerOfFlight;
using Airport.Pages.PassengerOfFlight;

namespace Airport.Soft.Areas.PassengerOfFlight.Pages.PassengerOfFlights
{
    public class IndexModel : PassengerOfFlightsPage
    {
        public IndexModel(IPassengerOfFlightsRepository r, IFlightsRepository p, IFlightOfPassengersRepository t) : base(r, p, t) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
            => await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
    }
}
