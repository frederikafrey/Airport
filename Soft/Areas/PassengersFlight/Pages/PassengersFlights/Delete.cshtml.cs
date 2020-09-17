using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.PassengersFlight;
using Airport.Infra;

namespace Airport.Soft.Areas.PassengersFlight.Pages.PassengersFlights
{
    public class DeleteModel : PageModel
    {
        private readonly AirportDbContext _context;

        public DeleteModel(AirportDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PassengersFlightData = await _context.PassengersFlights.FindAsync(id);

            if (PassengersFlightData != null)
            {
                _context.PassengersFlights.Remove(PassengersFlightData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
