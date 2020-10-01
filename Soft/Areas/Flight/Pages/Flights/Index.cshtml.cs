using System.Collections.Generic;
using System.Threading.Tasks;
using Airport.Data.Flight;
using Airport.Domain.AirlineCompany;
using Airport.Domain.Airport;
using Airport.Domain.Flight;
using Airport.Pages.Flight;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class IndexModel : FlightsPage
    {
        public IndexModel(IFlightsRepository r, IAirlineCompaniesRepository p, IAirportsRepository t) : base(r, p, t) { }

        public IList<FlightData> FlightData { get; set; }

        public async Task OnGetAsync(string sortOrder,
            string id, string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            await GetList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}
