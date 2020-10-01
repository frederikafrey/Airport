using System.Threading.Tasks;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.Passenger;
using Airport.Domain.StopOver;
using Airport.Pages.FlightOfPassenger;
using Microsoft.AspNetCore.Mvc;

namespace Airport.Soft.Areas.FlightOfPassenger.Pages.FlightOfPassengers
{
    public class DetailsModel : FlightOfPassengersPage
    {
        public DetailsModel(IFlightOfPassengersRepository r, IStopOversRepository p, IPassengersRepository t) : base(r, p, t) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
