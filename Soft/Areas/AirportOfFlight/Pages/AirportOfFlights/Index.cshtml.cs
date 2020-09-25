using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Domain.Airport;
using Airport.Domain.AirportOfFlight;
using Airport.Infra;
using Airport.Pages.Airport;
using Airport.Pages.AirportOfFlight;

namespace Airport.Soft.Areas.AirportOfFlight.Pages.AirportOfFlights
{
    public class IndexModel : AirportOfFlightPage
    {
        public IndexModel(IAirportOfFlightsRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await GetList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}
