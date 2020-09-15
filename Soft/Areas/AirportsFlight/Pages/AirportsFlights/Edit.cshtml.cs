using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Airport.Data.AirportsFlight;
using Airport.Infra;

namespace Airport.Soft.Areas.AirportsFlight.Pages.AirportsFlights
{
    public class EditModel : PageModel
    {
        private readonly AirportDbContext _context;

        public EditModel(AirportDbContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AirportsFlightData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AirportsFlightDataExists(AirportsFlightData.FlightId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AirportsFlightDataExists(string id)
        {
            return _context.AirportsFlights.Any(e => e.FlightId == id);
        }
    }
}
