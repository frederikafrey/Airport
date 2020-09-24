using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Airport.Data.FlightsPassenger;
using Airport.Domain.Flight;
using Airport.Domain.FlightsPassenger;
using Airport.Domain.Passenger;
using Airport.Infra;
using Airport.Pages.FlightsPassenger;

namespace Airport.Soft.Areas.FlightsPassenger.Pages.FlightsPassengers
{
    public class CreateModel : FlightsPassengerPage
    {
        public CreateModel(IFlightsPassengersRepository r, IFlightsRepository p, IPassengersRepository t) : base(r, p, t) { }
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
