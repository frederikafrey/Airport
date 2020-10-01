using System.Threading.Tasks;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Passenger;
using Airport.Domain.StopOver;
using Microsoft.AspNetCore.Mvc;
using Airport.Pages.FlightOfPassenger;

namespace Airport.Soft.Areas.FlightOfPassenger.Pages.FlightOfPassengers
{
    public class DeleteModel : FlightOfPassengersPage
    {
        public DeleteModel(IFlightOfPassengersRepository r, IStopOversRepository p, IPassengersRepository t) : base(r, p, t) { }
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
