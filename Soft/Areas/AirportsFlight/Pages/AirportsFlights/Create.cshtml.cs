using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Airport.Data.AirportsFlight;
using Airport.Infra;

namespace Airport.Soft.Areas.AirportsFlight.Pages.AirportsFlights
{
    public class CreateModel : PageModel
    {
        private readonly AirportDbContext _context;

        public CreateModel(AirportDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AirportsFlightData AirportsFlightData { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AirportsFlights.Add(AirportsFlightData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
