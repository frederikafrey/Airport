using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.AirportsFlight;
using Airport.Domain.Airport;
using Airport.Domain.AirportsFlight;
using Airport.Infra;
using Airport.Pages.Airport;
using Airport.Pages.AirportsFlight;

namespace Airport.Soft.Areas.AirportsFlight.Pages.AirportsFlights
{
    public class IndexModel : AirportsFlightPage
    {
        public IndexModel(IAirportsFlightsRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await GetList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}
