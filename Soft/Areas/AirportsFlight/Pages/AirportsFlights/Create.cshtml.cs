using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Airport.Data.AirportsFlight;
using Airport.Domain.Airport;
using Airport.Domain.AirportsFlight;
using Airport.Infra;
using Airport.Pages.Airport;
using Airport.Pages.AirportsFlight;

namespace Airport.Soft.Areas.AirportsFlight.Pages.AirportsFlights
{
    public class CreateModel : AirportsFlightPage
    {
        public CreateModel(IAirportsFlightsRepository r) : base(r) { }
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
