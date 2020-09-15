using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.FlightsPassenger;
using Airport.Infra;

namespace Airport.Soft.Areas.FlightsPassenger.Pages.FlightsPassengers
{
    public class DetailsModel : PageModel
    {
        private readonly AirportDbContext _context;

        public DetailsModel(AirportDbContext context)
        {
            _context = context;
        }

        public FlightsPassengerData FlightsPassengerData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FlightsPassengerData = await _context.FlightsPassengers.FirstOrDefaultAsync(m => m.PassengersFlightId == id);

            if (FlightsPassengerData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
