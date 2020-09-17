using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.FlightsPassenger;
using Airport.Infra;

namespace Airport.Soft.Areas.FlightsPassenger.Pages.FlightsPassengers
{
    public class DeleteModel : PageModel
    {
        private readonly AirportDbContext _context;

        public DeleteModel(AirportDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FlightsPassengerData = await _context.FlightsPassengers.FindAsync(id);

            if (FlightsPassengerData != null)
            {
                _context.FlightsPassengers.Remove(FlightsPassengerData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
