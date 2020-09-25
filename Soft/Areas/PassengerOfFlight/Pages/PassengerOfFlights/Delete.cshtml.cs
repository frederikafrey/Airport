using System.Threading.Tasks;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.PassengerOfFlight;
using Airport.Pages.PassengerOfFlight;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.PassengerOfFlight.Pages.PassengerOfFlights
{
    public class DeleteModel : PassengerOfFlightsPage
    {
        public DeleteModel(IPassengerOfFlightsRepository r, IFlightsRepository p, IFlightOfPassengersRepository t) : base(r, p, t) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await DeleteObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }

}
