using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    public class DetailsModel : AirportsFlightPage
    {
        public DetailsModel(IAirportsFlightsRepository r) : base(r) { }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
