using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.Flight;
using Airport.Infra;

namespace Airport.Soft.Areas.Flight.Pages.Flights
{
    public class DeleteModel : PageModel
    {
        private readonly AirportDbContext _context;

        public DeleteModel(AirportDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FlightData = await _context.Flights.FindAsync(id);

            if (FlightData != null)
            {
                _context.Flights.Remove(FlightData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
