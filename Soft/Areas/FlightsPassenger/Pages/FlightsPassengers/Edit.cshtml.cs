using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.FlightsPassenger;
using Airport.Infra;

namespace Airport.Soft.Areas.FlightsPassenger.Pages.FlightsPassengers
{
    public class EditModel : PageModel
    {
        private readonly AirportDbContext _context;

        public EditModel(AirportDbContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FlightsPassengerData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightsPassengerDataExists(FlightsPassengerData.PassengersFlightId))
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

        private bool FlightsPassengerDataExists(string id)
        {
            return _context.FlightsPassengers.Any(e => e.PassengersFlightId == id);
        }
    }
}
