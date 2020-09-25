using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Airport.Domain.Airport;
using Airport.Domain.AirportOfFlight;
using Airport.Infra;
using Airport.Pages.Airport;
using Airport.Pages.AirportOfFlight;

namespace Airport.Soft.Areas.AirportOfFlight.Pages.AirportOfFlights
{
    public class CreateModel : AirportOfFlightPage
    {
        public CreateModel(IAirportOfFlightsRepository r) : base(r) { }
        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await AddObject(fixedFilter, fixedValue))
            {
                return Page();
            }
            return Redirect(IndexUrl);
        }
    }
}
