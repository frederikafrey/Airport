using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.AirportsFlight;
using Airport.Infra;

namespace Airport.Soft.Areas.AirportsFlight.Pages.AirportsFlights
{
    public class DeleteModel : PageModel
    {
        private readonly AirportDbContext _context;

        public DeleteModel(AirportDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AirportsFlightData AirportsFlightData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AirportsFlightData = await _context.AirportsFlights.FirstOrDefaultAsync(m => m.FlightId == id);

            if (AirportsFlightData == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AirportsFlightData = await _context.AirportsFlights.FindAsync(id);

            if (AirportsFlightData != null)
            {
                _context.AirportsFlights.Remove(AirportsFlightData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
