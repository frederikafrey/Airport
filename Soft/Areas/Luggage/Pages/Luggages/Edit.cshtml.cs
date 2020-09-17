using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.Luggage;
using Airport.Infra;

namespace Airport.Soft.Areas.Luggage.Pages.Luggages
{
    public class EditModel : PageModel
    {
        private readonly AirportDbContext _context;

        public EditModel(AirportDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LuggageData LuggageData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LuggageData = await _context.Luggages.FirstOrDefaultAsync(m => m.Id == id);

            if (LuggageData == null)
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

            _context.Attach(LuggageData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LuggageDataExists(LuggageData.Id))
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

        private bool LuggageDataExists(string id)
        {
            return _context.Luggages.Any(e => e.Id == id);
        }
    }
}
