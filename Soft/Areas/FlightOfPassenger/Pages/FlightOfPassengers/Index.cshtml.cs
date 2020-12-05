using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Luggage;
using Airport.Domain.Passenger;
using Airport.Pages.FlightOfPassenger;

namespace Airport.Soft.Areas.FlightOfPassenger.Pages.FlightOfPassengers
{
    public class IndexModel : FlightOfPassengersPage
    {
        public IndexModel(IFlightOfPassengersRepository r, IPassengersRepository p, IFlightsRepository f, ILuggagesRepository l) : base(r, p, f, l) { }
        
        public async Task OnGetAsync(string sortOrder, string id, string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }

        public override string ItemId { get; }
    }
}
