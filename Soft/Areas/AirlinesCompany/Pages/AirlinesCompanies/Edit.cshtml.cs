using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.AirlinesCompany;
using Airport.Infra;

namespace Airport.Soft.Areas.AirlinesCompany.Pages.AirlinesCompanies
{
    public class EditModel : PageModel
    {
        private readonly AirportDbContext _context;

        public EditModel(AirportDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AirlinesCompanyData AirlinesCompanyData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AirlinesCompanyData = await _context.AirlinesCompanies.FirstOrDefaultAsync(m => m.Id == id);

            if (AirlinesCompanyData == null)
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

            _context.Attach(AirlinesCompanyData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AirlinesCompanyDataExists(AirlinesCompanyData.Id))
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

        private bool AirlinesCompanyDataExists(string id)
        {
            return _context.AirlinesCompanies.Any(e => e.Id == id);
        }
    }
}
