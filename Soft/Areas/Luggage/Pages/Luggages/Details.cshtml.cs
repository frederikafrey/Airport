using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airport.Data.Luggage;
using Airport.Infra;

namespace Airport.Soft.Areas.Luggage.Pages.Luggages
{
    public class DetailsModel : PageModel
    {
        private readonly AirportDbContext _context;

        public DetailsModel(AirportDbContext context)
        {
            _context = context;
        }

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
    }
}
