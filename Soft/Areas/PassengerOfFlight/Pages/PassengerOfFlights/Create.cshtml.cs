using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.PassengerOfFlight;
using Airport.Pages.PassengerOfFlight;

namespace Airport.Soft.Areas.PassengerOfFlight.Pages.PassengerOfFlights
{
    public class CreateModel : PassengerOfFlightsPage
    {
        public CreateModel(IPassengerOfFlightsRepository r, IFlightsRepository p, IFlightOfPassengersRepository t) : base(r, p, t) { }
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
