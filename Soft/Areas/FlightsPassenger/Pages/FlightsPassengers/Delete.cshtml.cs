using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.FlightsPassenger;
using Airport.Domain.Flight;
using Airport.Domain.FlightsPassenger;
using Airport.Domain.Passenger;
using Airport.Domain.PassengersFlight;
using Airport.Infra;
using Airport.Pages.FlightsPassenger;

namespace Airport.Soft.Areas.FlightsPassenger.Pages.FlightsPassengers
{
    public class DeleteModel : FlightsPassengerPage
    {
        public DeleteModel(IFlightsPassengersRepository r, IFlightsRepository p, IPassengersFlightsRepository t) : base(r, p, t) { }
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
