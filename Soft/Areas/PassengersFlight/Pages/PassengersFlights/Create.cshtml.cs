using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Airport.Data.PassengersFlight;
using Airport.Infra;
using Airport.Pages.FlightsPassenger;
using Airport.Domain.FlightsPassenger;
using Airport.Pages.PassengersFlight;
using Airport.Domain.PassengersFlight;

namespace Airport.Soft.Areas.PassengersFlight.Pages.PassengersFlights
{
    public class CreateModel : PassengersFlightsPage
    {
        public CreateModel(IPassengersFlightsRepository r) : base(r) { }

        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await AddObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
