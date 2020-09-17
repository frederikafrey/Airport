using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.Passenger;
using Airport.Infra;

namespace Airport.Soft.Areas.Passenger.Pages.Passengers
{
    public class EditModel : PageModel
    {
        private readonly AirportDbContext _context;

        public EditModel(AirportDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PassengerData PassengerData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PassengerData = await _context.Passengers.FirstOrDefaultAsync(m => m.Id == id);

            if (PassengerData == null)
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

            _context.Attach(PassengerData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PassengerDataExists(PassengerData.Id))
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

        private bool PassengerDataExists(string id)
        {
            return _context.Passengers.Any(e => e.Id == id);
        }
    }
}
