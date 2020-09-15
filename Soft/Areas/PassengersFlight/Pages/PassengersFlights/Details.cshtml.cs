using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.PassengersFlight;
using Airport.Infra;

namespace Airport.Soft.Areas.PassengersFlight.Pages.PassengersFlights
{
    public class DetailsModel : PageModel
    {
        private readonly AirportDbContext _context;

        public DetailsModel(AirportDbContext context)
        {
            _context = context;
        }

        public PassengersFlightData PassengersFlightData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PassengersFlightData = await _context.PassengersFlights.FirstOrDefaultAsync(m => m.FlightsPassengerId == id);

            if (PassengersFlightData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
