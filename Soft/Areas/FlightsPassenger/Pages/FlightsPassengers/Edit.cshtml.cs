using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.FlightsPassenger;
using Airport.Domain.Flight;
using Airport.Domain.FlightOfPassenger;
using Airport.Domain.FlightsPassenger;
using Airport.Domain.Passenger;
using Airport.Infra;
using Airport.Pages.FlightsPassenger;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airport.Soft.Areas.FlightsPassenger.Pages.FlightsPassengers
{
    public class EditModel : FlightsPassengerPage
    {
        public EditModel(IFlightsPassengersRepository r, IFlightsRepository p, IFlightOfPassengersRepository t) : base(r, p, t) { }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await GetObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            await UpdateObject(fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }
}
