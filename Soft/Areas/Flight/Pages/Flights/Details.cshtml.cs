using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.Flight;
using Airport.Infra;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class DetailsModel : PageModel
    {
        private readonly AirportDbContext _context;

        public DetailsModel(AirportDbContext context)
        {
            _context = context;
        }

        public FlightData FlightData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FlightData = await _context.Flights.FirstOrDefaultAsync(m => m.Id == id);

            if (FlightData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
